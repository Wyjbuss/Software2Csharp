using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software2Csharp
{
    public partial class Customers : UserControl
    {
        private int currentSelectedRow;

        private FormAddNewCustomer frmm;
        private FormUpdateCustomer UpdateCustomerForm;

        public MySqlConnection cnn;
        public MySqlCommand cmd;
        public Customers()
        {
            InitializeComponent();
            LoadMySqlData loadData = new LoadMySqlData();
            loadData.LoadCustomerData(dataGridViewCustomers);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ButtonCreateNewCustomer_Click(object sender, EventArgs e)
        {
            FormAddNewCustomer frm = new FormAddNewCustomer();
            frmm = frm;
            frmm.Show();
            frmm.onAppExit += Frm_onAppExit;
        }

        private void Frm_onAppExit(object sender, EventArgs e)
        {
            LoadMySqlData loadMySqlData = new LoadMySqlData();
            loadMySqlData.LoadCustomerData(dataGridViewCustomers);
            frmm.onAppExit -= Frm_onAppExit;

        }

        private void guna2ButtonDeleteCutomer_Click(object sender, EventArgs e)
        {
            
            string customerId = dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
           
            // find the selected rows customerId
            ClassCustomers classCustomers = new ClassCustomers();
            try
            {
                classCustomers.removeCustomer(int.Parse(customerId));
            }
            catch (Exception)
            {

                Console.WriteLine("Error: can't parse customerId to string");
            }
            

            LoadMySqlData loadMySqlData = new LoadMySqlData();
            loadMySqlData.LoadCustomerData(dataGridViewCustomers);
        }

        private void guna2ButtonUpdateCustomer_Click(object sender, EventArgs e)
        {
            //gets the values of the selected customer's values
            string customerId = dataGridViewCustomers.CurrentRow.Cells[0].Value.ToString();
            string customerName = dataGridViewCustomers.CurrentRow.Cells[1].Value.ToString();
            string addressId = dataGridViewCustomers.CurrentRow.Cells[2].Value.ToString();
            string active = dataGridViewCustomers.CurrentRow.Cells[3].Value.ToString();
            string createDate = dataGridViewCustomers.CurrentRow.Cells[4].Value.ToString();
            string createBy = dataGridViewCustomers.CurrentRow.Cells[5].Value.ToString();
            string lastUpdated = dataGridViewCustomers.CurrentRow.Cells[6].Value.ToString();
            string lastUpdatedBy = dataGridViewCustomers.CurrentRow.Cells[7].Value.ToString();

            ClassCustomers currentCustomer = new ClassCustomers();
            currentCustomer.customerId = int.Parse(customerId);
            currentCustomer.name = customerName;
            currentCustomer.addressId = int.Parse(addressId);
            currentCustomer.active = bool.Parse(active);
            currentCustomer.updatedDate = DateTime.Parse(lastUpdated);
            currentCustomer.updatedBy = lastUpdatedBy;



            UpdateCustomerForm = new FormUpdateCustomer();
            UpdateCustomerForm.Show();
            UpdateCustomerForm.LoadCurrentSelectedCustomer(currentCustomer);

            //refresh the table
            UpdateCustomerForm.OnFormExit += UpdateCustomerForm_OnFormExit;
            UpdateCustomerForm.LoadCurrentSelectedCustomer(currentCustomer);

            

        }

        private void UpdateCustomerForm_OnFormExit(object sender, EventArgs e)
        {
            LoadMySqlData loadMySqlData = new LoadMySqlData();
            loadMySqlData.LoadCustomerData(dataGridViewCustomers);
            UpdateCustomerForm.OnFormExit -= UpdateCustomerForm_OnFormExit;
        }
    }
}
