using HowTo.DesignPatterns.Repository;
using HowTo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmLabAnalysis : Form
    {
        private readonly LabAnalysisRepository _repository;

        public frmLabAnalysis()
        {
            InitializeComponent();
            _repository = new LabAnalysisRepository();
        }

        private void frmLabAnalysis_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            var procedures = _repository.GetAllProcedures();
            this.dgLabAnalysis.DataSource = procedures;

            // Optional: Rename columns for a clearer display
            this.dgLabAnalysis.Columns["LabAnalysisID"].HeaderText = "Lab Analysis ID";
            this.dgLabAnalysis.Columns["RequestedAnalName"].HeaderText = "Requested Analysis Name";
            this.dgLabAnalysis.Columns["ProcedName"].HeaderText = "Procedure Name";
            this.dgLabAnalysis.Columns["ProcedAbbrev"].HeaderText = "Procedure Abbreviation";
            this.dgLabAnalysis.Columns["ProcedDesc"].HeaderText = "Procedure Description";
            this.dgLabAnalysis.Columns["SSIR5Page"].HeaderText = "SSIR 5 Page";
            this.dgLabAnalysis.Columns["PDFPage"].HeaderText = "PDF Page";
            this.dgLabAnalysis.Columns["LinksToSSIR42V5"].HeaderText = "Links to SSIR 42 V5";
            this.dgLabAnalysis.Columns["Notes"].HeaderText = "Notes";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(HowToForm));
            t.Start();
        }

        private void HowToForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmHowTo());
        }

        private void btnAddLab_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(AddLabForm));
            t.Start();
        }

        private void AddLabForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmLabAnalysisAdd());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check if a row is selected
            if (this.dgLabAnalysis.SelectedRows.Count == 0)
            {
                //No row selected - show an error message
                MessageBox.Show("Please select a lab to delete.", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Get the LabAnalysisID of the selected row
            int selectedLabId = Convert.ToInt32(this.dgLabAnalysis.SelectedRows[0].Cells["LabAnalysisID"].Value);

            //Confirm deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this lab?", TitlesModel.MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Call repository to delete the lab
                _repository.DeleteProcedure(selectedLabId);

                // Refresh the DataGridView to reflect changes
                this.LoadDataGridView();

                // Notify the user of successful deletion
                MessageBox.Show("Lab deleted successfully.", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
