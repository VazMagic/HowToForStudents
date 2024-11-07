using HowTo.Events;
using HowTo.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SetForm1PropertyFromForm2
{
    public partial class frmAddCustomers : Form
    {
        //Delegate
        public delegate void CustomersHandler(object sender, UpdateCustomersEventArgs e);

        //Event for Delegate 
        //Type CustomersHandler matches the Delegate above
        //UpdateCustomers is the variable used by Form1
        public event CustomersHandler UpdateCustomers;

        //ArrayList - Updated by Form1
        public List<PersonsModel> Customers;

        public frmAddCustomers()
        {
            InitializeComponent();
        }

        private void frmAddCustomers_Load(object sender, EventArgs e)
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Event Class which is used with the Delegate
            //This helps us pass the changes to the ArrayList Customers to the class 
            //and Retrieved from Form1 "CustomerUpdate" method
            UpdateCustomersEventArgs args = new UpdateCustomersEventArgs(Customers);
            
            //Event declared above
            UpdateCustomers(this, args);

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.PerformValidation())
                return;

            this.AddCustomer();

        }

        private void AddCustomer()
        {
            //User is adding a customer. Add it to the Customer ArrayList
            Customers.Add(new PersonsModel()
            {
                Person = this.txtCustomer.Text.Trim()
            });

            //Success
            MessageBox.Show("Customer " + this.txtCustomer.Text.Trim() + " successfully added!", 
                            TitlesModel.MessageBoxTitle,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Clear TextBox
            this.txtCustomer.Text = String.Empty;
        }

        private bool PerformValidation()
        {
            //Verify that the textbox is not empty
            if (String.IsNullOrEmpty(this.txtCustomer.Text.Trim()))
            {
                MessageBox.Show("A Customer must be entered!", 
                                TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Set Focust to the Customer TextBox so User CAN enter a customer
                this.txtCustomer.Focus();
                return false;
            }
            
            return true;
        }

    }
}
