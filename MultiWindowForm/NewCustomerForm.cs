using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowForm
{
    public partial class NewCustomerForm : Form
    {
        private MainForm _mainForm;

        public NewCustomerForm(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validation

            // create a customer and load it with the data from the form
            Customer customer = new Customer
            {
                CustomerId = 0,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text,
            };

            // send that data to the AddCustomer function on the parent form
            _mainForm.AddCustomer(customer);

            // clear the new customer form
            // close the form if we want to
        }
    }
}
