using SetForm1PropertyFromForm2;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmHowTo : Form
    {
        public frmHowTo()
        {
            InitializeComponent();
        }

        private void frmHowTo_Load(object sender, EventArgs e)
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
        }

        private void btnOpenSecondForm_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(ThreadFormTwo));
            t.Start();
        }

        private void ThreadFormTwo()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmSecondForm());
        }

        private void btnDelegates_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.Show();
        }

        private void btnImportTextFile_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                frmImportTextFileData importtextfiledata = new frmImportTextFileData();
                importtextfiledata.ShowDialog();

            });
            thread.SetApartmentState(ApartmentState.STA);  // Set the thread to STA
            thread.Start();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            frmExportData export = new frmExportData();
            export.Show();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            frmData data = new frmData();
            data.Show();
        }

        private void btnExportDataGridViewData_Click(object sender, EventArgs e)
        {
            frmExportData data = new frmExportData();
            data.Show();
        }

        private void btnDbase_Click(object sender, EventArgs e)
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
    }
}
