using HowTo.DesignPatterns.Repository;
using HowTo.Processes;
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
    public partial class frmLabAnalysisAdd : Form
    {
        private readonly LabAnalysisRepository _repository;

        public frmLabAnalysisAdd()
        {
            InitializeComponent();
            _repository = new LabAnalysisRepository();
        }

        private void frmLabAnalysisAdd_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.txtProcedAbbrev.Text = string.Empty;
            this.txtProcedDesc.Text = string.Empty;
            this.txtProcedName.Text = string.Empty;
            this.txtRequestedAnalName.Text = string.Empty;
            this.txtLinksToSSIR42V5.Text = string.Empty;
            this.txtSSIR5Page.Text = string.Empty;
            this.txtPDFPage.Text = string.Empty;
            this.rtNotes.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(LabAnalysisForm));
            t.Start();
        }

        private void LabAnalysisForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmLabAnalysis());
        }

        private void btnAddLab_Click(object sender, EventArgs e)
        {
            int iPDF = 0;
            int iSSIR5Page = 0;

            //Call the method to verify and convert
            if (Utility.TryConvertToInt(this.txtPDFPage.Text.Trim(), out int pdfNo))
            {
                //Success: assign the result
                iPDF = pdfNo;
                Console.WriteLine("The page number is: " + iPDF);
            }
            else
            {
                //Failed conversion: inform the user
                MessageBox.Show("Please enter a valid integer for PDFPage.");
                return;
            }

            //Call the method to verify and convert
            if (Utility.TryConvertToInt(this.txtPDFPage.Text.Trim(), out int ssir5No))
            {
                //Success: assign the result
                iSSIR5Page = ssir5No;
            }
            else
            {
                //Failed conversion: inform the user
                MessageBox.Show("Please enter a valid integer for SSIR5Page.");
                return;
            }

            LabAnalysisProcedure labAnalysisProcedure = new LabAnalysisProcedure();

            labAnalysisProcedure.LinksToSSIR42V5 = this.txtLinksToSSIR42V5.Text.Trim();
            labAnalysisProcedure.PDFPage = iPDF;
            labAnalysisProcedure.ProcedAbbrev = this.txtProcedAbbrev.Text.Trim();
            labAnalysisProcedure.ProcedDesc = this.txtProcedDesc.Text.Trim();
            labAnalysisProcedure.ProcedName = this.txtProcedName.Text.Trim();
            labAnalysisProcedure.RequestedAnalName = this.txtRequestedAnalName.Text.Trim();
            labAnalysisProcedure.SSIR5Page = iSSIR5Page;
            labAnalysisProcedure.Notes = this.rtNotes.Text.Trim();

            _repository.AddProcedure(labAnalysisProcedure);

            //Added
            MessageBox.Show("Successfully added Lab Analysis.");
            this.SetControls();
        }
    }
}
