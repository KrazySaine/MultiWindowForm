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
                Name = "Jesse",
                Email = "jesse.harlan@centralia.edu",
                PhoneNumber = "555-2722"
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
    }
}
