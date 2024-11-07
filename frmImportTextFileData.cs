using HowTo.Models;
using HowTo.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmImportTextFileData : Form
    {
        List<PersonsModel> characters = new List<PersonsModel>();
        string selectedfile = string.Empty;

        public frmImportTextFileData()
        {
            InitializeComponent();
        }

        private void frmImportTextFileData_Load(object sender, EventArgs e)
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.OpenFileDialogWindow();
            this.ImportData();
        }

        private void OpenFileDialogWindow()
        {
            string dbasepath = CurrentPath.GetDbasePath();

            OpenFileDialog openDialog = new OpenFileDialog();

            //Set Title of OpenFileDialog
            openDialog.Title = "Select A Text File";
            //Set directory path
            //Occasional Errors Here
            openDialog.InitialDirectory = dbasepath;

            //Set the File Filter of OpenFileDialog
            openDialog.Filter = "Text (*.txt)|*.txt" + "|" +
                                "CSV (*.csv)|*.csv" + "|" +
                                "All Files (*.*)|*.*";

            //Get the OK press of the Dialog Box
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Get Selected File
                selectedfile = openDialog.FileName;
            }
        }

        private void ImportData()
        {
            //Get Guaridan of the Galaxy Characters from text file
            characters = TexFiletInputOutput.GetGuardiansData(selectedfile);

            //Use LINQ to get customers from the CustomersModel
            var theguardians = (from c in characters
                             select c.Person).ToList();

            //Set the DataSource of the listbox to the customers collection
            this.lstCharacters.DataSource = theguardians;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
