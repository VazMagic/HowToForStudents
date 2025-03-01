﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HowTo.Processes;
using ImportExportData;
using ImportExportData.Events;

namespace HowTo
{
    public partial class frmData : Form
    {
        DataTable _dt = new DataTable();
        bool isXML = false;
        bool isInsuranceData = false;

        public frmData()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //Labels
            this.lblSearch.Text = "Search Criteria";

            //Set Radio Button Default
            this.rbLocation.Checked = true;

            //Set record count
            this.lblTotal.Text = "0";

            this.isInsuranceData = true;
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            isXML = false;

            //Create Instance of the Import Excel Form
            frmImportExcelData frmImport = new frmImportExcelData();

            //Access the Event which is used by the Delegate
            //Pass in a method on THIS FORM to the ImportExcelData Form
            //This will cause the Deletegate on the ImportExcelData Form
            //To access the method on this Form
            frmImport.UpdateDataGridView += new frmImportExcelData.UpdateDGVHandler(PopulateDataGridView);
            
            //Show the form
            frmImport.ShowDialog();
        }

        private void btnImportXML_Click(object sender, EventArgs e)
        {
            isXML = true;

            //Create Instance of the Import XML Form
            frmImportXMLData frmImport = new frmImportXMLData();

            //Access the Event which is used by the Delegate
            //Pass in a method on THIS FORM to the ImportXMLData Form
            //This will cause the Deletegate on the ImportXMLData Form
            //To access the method on this Form
            frmImport.UpdateDataGridView += new frmImportXMLData.UpdateDGVHandler(PopulateDataGridView);

            //Show the form
            frmImport.ShowDialog();
        }

        private void PopulateDataGridView(object sender, UpdateDataGridViewEventArgs e)
        {
            //*****************************************************
            //This method is accessed from the ImportExcelData or
            //ImportXMLData form via the delegate
            //*****************************************************

            //First we want to store the DataSet from the Import Process
            //_ds = e.GetDataSet;

            //1st Process the DataSet then assign to "_dt"
            _dt = e.GetDataSet.Tables[0];
            this.RemoveLeadingTrailingSpaces();

            //2nd Set the DataSource of the DataGridView to the DataTable "_dt"
            if (!isXML)
                this.grdData.DataSource = _dt = ProcessDataSet(_dt);
            else
                this.grdData.DataSource = _dt;

            //Set record count
            this.lblTotal.Text = _dt.Rows.Count.ToString();

            //Format columns in the DataGridView
            if (this.isInsuranceData)
            {
                this.FormatDataGridViewColumns();
                this.FormatDataGridViewColumnHeaders();
            }

            isXML = false;
        }

        private void RemoveLeadingTrailingSpaces()
        {
            var dataRows = _dt.AsEnumerable();
            foreach (var row in dataRows)
            {
                var cellList = row.ItemArray.ToList();
                row.ItemArray = cellList.Select(x => x.ToString().Trim()).ToArray();
            };

            _dt = dataRows.CopyToDataTable();
            _dt.AcceptChanges();
        }

        private void FormatDataGridViewColumnHeaders()
        {
            //Set the Background Color of the Column Header
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            this.grdData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Set the Font for the Column Header
            this.grdData.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);

            //Autosize the coulumns
            this.grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FormatDataGridViewColumns()
        {
            //Format Column as a Short Date Time. Example -> 9/11/21
            this.grdData.Columns["Expiry"].DefaultCellStyle.Format = String.Format("d");
            //Align Right
            this.grdData.Columns["Expiry"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Format Column as Currency
            this.grdData.Columns["InsuredValue"].DefaultCellStyle.Format = String.Format("C");
            //Align Right
            this.grdData.Columns["InsuredValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private DataTable ProcessDataSet(DataTable dt)
        {
            //Variable
            int index = 0;

            //Get Column Names from the DataTable
            foreach (DataColumn dc in dt.Columns)
            {
                dc.ColumnName = dt.Rows[0][index].ToString();
                index++;
            }

            //**********************************************
            //Delete first row which contains column headers
            //**********************************************
            //Create a DataRow and populate with the DataTable
            DataRow[] dr = dt.Select();
            //Delete The first Row
            dr[0].Delete();
            //Update the DataTable by Accept the Changes
            dt.AcceptChanges();

            if (this.isInsuranceData)
            {
                dt = DataSetTableFunctions.FixDateTimeCol(dt);
                dt = DataSetTableFunctions.FixCurrencyCol(dt);
            }

            return dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get the current data from the DataGrid
            DataTable dt = (DataTable)this.grdData.DataSource;

            //Accept any changes made in the DataGridView
            dt.AcceptChanges();

            //Ensure that there is data to filter
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to search");
                return;
            }

            string field = string.Empty;
            string searchCriteria = this.txtSearch.Text.Trim();

            //Determine the search criteria to set the column to search
            if (rbLocation.Checked)
            {
                field = "Location";
            }
            else if (rbState.Checked)
            {
                field = "State";
            }
            else if (rbRegion.Checked)
            {
                field = "Region";
            }
            else if (rbConstruction.Checked)
            {
                field = "Construction";
            }
            else if (rbBusinessType.Checked)
            {
                field = "BusinessType";
            }
            else if (rbEarthquake.Checked)
            {
                field = "Earthquake";
            }
            else if (rbFlood.Checked)
            {
                field = "Flood";
            }

            //Search for data - Returns a DataRow
            var filtered = dt.AsEnumerable().Where(x => x.Field<string>(field) == searchCriteria);

            try
            {
                //********************
                //Convert to DataTable
                //********************
                //If filtered has no rows an error will occur when copying to a datatable
                dt = filtered.CopyToDataTable();
                //Copy dataTable to DataGrid
                this.grdData.DataSource = dt;
                //Set record count
                this.lblTotal.Text = dt.Rows.Count.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Search data was not found!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset to original imported data
            if (!(_dt == null) && _dt.Rows.Count > 0)
                this.grdData.DataSource = _dt;

            //Set record count
            this.lblTotal.Text = _dt.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            //Cast the DataGridView as a DataTable
            dt = (DataTable)this.grdData.DataSource;
            
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no data to export!");
                return;
            }

            frmExportXLSXOrXMLData export = new frmExportXLSXOrXMLData();
            //Pass DataTable to the ExportData Form
            export.Data = dt;
            export.ShowDialog();
        }

        private void chkNotInsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkNotInsurance.Checked)
                this.isInsuranceData = false;
            else
                this.isInsuranceData = true;

            this.EnableSearch();
        }

        private void EnableSearch()
        {
            this.gbCriteria.Enabled = this.isInsuranceData;
            this.txtSearch.Enabled = isInsuranceData;
            this.btnSearch.Enabled = isInsuranceData;
        }
    }
}
