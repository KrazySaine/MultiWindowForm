namespace MultiWindowForm
{
    public partial class MainForm : Form
    {
        private NewCustomerForm _customerForm;
        private List<Customer> _customerList;

        public MainForm()
        {
            InitializeComponent();
            _customerForm = new NewCustomerForm(this);
            _customerList = new List<Customer>();

            _customerList.Add(new Customer
            {
                Name = "Joey",
                Email = "JoSchmo@gotem.com",
                PhoneNumber = "867-5309"
            });

            ReloadDataGrid();
        }

        private void ReloadDataGrid()
        {
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _customerList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _customerForm.ShowDialog();
        }

        public void AddCustomer(Customer customer)
        {
            _customerList.Add(customer);
            ReloadDataGrid();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (_customerForm == null)
            {
                _customerForm = new NewCustomerForm(this);
            }
            //get the row out of the data grid view (dgv)
            Customer cust;
            //get the position of the first selected item from the data grid view


            var index = dgvCustomers.SelectedRows[0].Index;
            //get the customer from the list at that position
            cust = _customerList[index];
            //load the customer into the form

            _customerForm.LoadCustomer(cust);

            //show the form
            _customerForm.Show();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
