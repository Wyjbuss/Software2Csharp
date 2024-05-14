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
            frm.Show();
        }

        private void guna2ButtonDeleteCutomer_Click(object sender, EventArgs e)
        {

        }
    }
}
