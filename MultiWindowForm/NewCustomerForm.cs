using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowForm
{
    public partial class NewCustomerForm : Form
    {
        private MainForm _mainForm;
        private int CustomerCount = 0;

        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            CustomerCount++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validation

            // create a customer and load it with the data from the form
            Customer customer = new Customer
            {
                CustomerId = CustomerCount,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
            };

            // send that data to the AddCustomer function on the parent form
            _mainForm.AddCustomer(customer);

            ClearForm();
            Hide();
        }
        // clear the new customer form
        private void ClearForm()
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearForm();
        }

        public void LoadCustomer(Customer customer)
        {
            txtName.Text = customer.Name;
            txtPhoneNumber.Text = customer.PhoneNumber;
            txtEmail.Text = customer.Email;
        }
        // close the form if we want to
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
