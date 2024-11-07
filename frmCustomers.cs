using HowTo.Events;
using HowTo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SetForm1PropertyFromForm2
{
    public partial class frmCustomers : Form
    {
        //Create new instance of CustomersModel
        List<PersonsModel> Customers = new List<PersonsModel>();

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();

            //Get list of customers - mimic getting data from database
            Customers = PersonsModel.GetCustomers();
            
            this.PopulateCustomers();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void PopulateCustomers()
        {
            //Use LINQ to get customers from the CustomersModel
            var customers = (from c in Customers
                             select c.Person).ToList();

            //Set the DataSource of the listbox to the customers collection
            this.lstCustomers.DataSource = customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create new instance of "Add Customers" form
            frmAddCustomers frm2 = new frmAddCustomers();

            //Pass Customers object to Form2 public property
            frm2.Customers = this.Customers;

            //Access the Event which is used by the Delegate
            //Pass in a method on THIS FORM 
            //This will cause the Deletegate on the "Add Customers" Form
            //To access the method on this Form (Customers)
            //UpdateCustomers is the Variable declared in "Add Customers" form
            //CustomersHandler is the delegate declared in "Add Customers" form
            frm2.UpdateCustomers += new frmAddCustomers.CustomersHandler(CustomersUpdate);

            //Display Form2
            frm2.ShowDialog();
        }

        private void CustomersUpdate(object s, UpdateCustomersEventArgs e)
        {
            //Get the customers from "Add Customers" form which was passed to the
            //UpdateCustomersEventArg Class that we created for this
            Customers = e.GetCustomers;

            //Populate the listbox with new changes to Customers
            this.PopulateCustomers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
