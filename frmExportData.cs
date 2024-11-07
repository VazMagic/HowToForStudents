using HowTo.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmExportData : Form
    {
        List<PersonsModel> data = new List<PersonsModel>();

        public frmExportData()
        {
            InitializeComponent();
        }

        private void frmExportToTextFile_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.ValidateEntry();
            this.txtData.Text = String.Empty;
        }

        private void ValidateEntry()
        {
            if (this.txtData.Text.Trim() == String.Empty)
            {
                MessageBox.Show(this, "No data to add!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.AddData();
        }

        private void AddData()
        {
            if (FindDuplicates())
                return;

            data.Add(new PersonsModel()
            {
                Person = this.txtData.Text.Trim()
            });

            this.AddToList();
        }

        private void AddToList()
        {
            //LINQ - Get Person Field Data from ArrayList
            var results = (from d in data
                           select d.Person).ToList();

            this.lstData.DataSource = results;
        }

        private bool FindDuplicates()
        {
            string msg = this.txtData.Text.Trim() + " already exists!";

            var duplicates = data.Where(x => x.Person == this.txtData.Text.Trim()).ToList();

            if (duplicates.Count > 0)
            {
                MessageBox.Show(this, msg, TitlesModel.MessageBoxTitle, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = this.lstData.SelectedValue;

            data.RemoveAll(x => x.Person == value.ToString());

            this.AddToList();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var results = (from d in data
                           select d.Person).ToList();

            if (results.Count == 0)
            {
                MessageBox.Show(this, "There is no data to export!", TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmExport export = new frmExport();
            export.Data = data;
            export.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
