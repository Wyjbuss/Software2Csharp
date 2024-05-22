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
    }
}
