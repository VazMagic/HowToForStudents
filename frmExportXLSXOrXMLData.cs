using HowTo.Models;
using HowTo.Processes;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmExportXLSXOrXMLData : Form
    {
        DataTable _dt = new DataTable();
        bool _success = false;

        public frmExportXLSXOrXMLData()
        {
            InitializeComponent();
        }

        public DataTable Data 
        {

            set
            {
                _dt = value;
            }
        }

        private void ExportData_Load(object sender, EventArgs e)
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

            //TextBox
            this.txtLocation.Enabled = false;

            //Raddio Button
            this.rbExcel.Checked = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string file = string.Empty;
            string ext = string.Empty;

            int count = _dt.Rows.Count;

            if (!this.PerformValidation())
                return;

            file = this.txtLocation.Text + "\\" +
                   this.txtFileName.Text.Trim();

            if (this.rbExcel.Checked)
            {
                if (!this.chkPartition.Checked || (this.chkPartition.Checked && count < 1500000))
                {
                    file += ".xlsx";
                    _success = ExportExcel.ExportExcelData(_dt, file);
                }
                else
                {
                    int chunkSize = 500000;
                    int fileNo = 1;
                    int totalRecords = count;
                    int getSize = totalRecords;
                    int recordsToSkip = 0;

                    while (totalRecords > 0)
                    {
                        string exportFile = file + "-" + fileNo.ToString() + ".xlsx";

                        int currentChunkSize = Math.Min(chunkSize, totalRecords);
                        var recordsToExport = _dt.AsEnumerable().Skip(recordsToSkip).Take(currentChunkSize).ToList();
                        DataTable dtExport = recordsToExport.CopyToDataTable();

                        _success = ExportExcel.ExportExcelData(dtExport, exportFile);

                        recordsToSkip += chunkSize;
                        totalRecords -= chunkSize;

                        fileNo++;
                    }
                }

            }
            else if (this.rbXML.Checked)
            {
                file += ".xml";
                _success = ExportXML.ExportXMLData(_dt, file);
            }

            string result = string.Empty;

             if (_success)
            {
                result = " was successful!";
            }
            else
            {
                result = " failed!";
            }

            MessageBox.Show("Export " + file + result, TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.txtLocation.Text = folderBrowserDialog1.SelectedPath;
        }

        private bool PerformValidation()
        {
            if (String.IsNullOrEmpty(this.txtLocation.Text.Trim()))
            {
                MessageBox.Show("Directory must be provided!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (String.IsNullOrEmpty(this.txtFileName.Text.Trim()))
            {
                MessageBox.Show("A File Name must be provided!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
