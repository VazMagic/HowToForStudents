using System;
using System.Data;
using System.Windows.Forms;
using HowTo.Processes;
using ImportExportData.Events;

namespace HowTo
{
    public partial class frmImportXMLData : Form
    {
        //*****************************************************
        // A Delegate is similar to a POINTER. They are used to 
        // implement events. For this example, the delegate
        // "UpdateDGVHandler" is wired to the Data.cs form.
        //*****************************************************

        //Delegate is created to update the DataGridView in the Data Form
        //The "UpdateDataGridViewEventArgs" is a CLASS we create in the Events Folder
        public delegate void UpdateDGVHandler(object sender, UpdateDataGridViewEventArgs e);

        //Event
        public event UpdateDGVHandler UpdateDataGridView;

        //Variables
        string _file = string.Empty;

        public frmImportXMLData()
        {
            InitializeComponent();
        }

        private void ImportXMLData_Load(object sender, EventArgs e)
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

            //Label
            this.lblFile.Text = "Selected File";

            //TextBox
            this.txtFile.Enabled = false;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            //Set Tile of OpenFileDialog
            openDialog.Title = "Select An XML File";

            //Set the File Filter of OpenFileDialog
            openDialog.Filter = "XML (*.xml)|*.xml" + "|" +
                                "All Files (*.*)|*.*";

            //Get the OK press of the Dialog Box
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Get Selected File
                _file = openDialog.FileName;
                this.txtFile.Text = _file;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //Change cursor to wait
            Cursor.Current = Cursors.WaitCursor;

            DataSet ds = ImportXML.GetXMLData(_file);

            //Event Class which is used with the Delegate
            UpdateDataGridViewEventArgs args = new UpdateDataGridViewEventArgs(ds);
            //Event
            UpdateDataGridView(this, args);
            
            //Return cursor to default
            Cursor.Current = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //User wants to close the form
            this.Dispose();
        }
    }
}
