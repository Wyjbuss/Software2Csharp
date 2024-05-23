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
    public partial class FormUpdateCustomer : Form
    {
        public ClassCustomers updatedCustomer;
        private int customerId;
        public event EventHandler OnFormExit;
        public FormUpdateCustomer()
        {
            InitializeComponent();
        }

        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            updatedCustomer = new ClassCustomers();

            updatedCustomer.name = guna2TextBoxName.Text.ToString().Trim();
            updatedCustomer.addressId = 3;
            updatedCustomer.active = true;
            updatedCustomer.updatedBy = "test";

            try
            {
                updatedCustomer.updateCustomer(updatedCustomer, customerId);
                this.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Error updating customer");
            }
            


        }

        public void LoadCurrentSelectedCustomer(ClassCustomers customerToLoad)
        {
            customerId = customerToLoad.customerId;

            guna2TextBoxName.Text = customerToLoad.name;
            guna2TextBoxAddress.Text = customerToLoad.addressId.ToString();
            guna2TextBoxPhoneNumber.Text = customerToLoad.phoneNumber.ToString();
            guna2TextBoxPostalCode.Text = customerToLoad.postalCode;
            guna2TextBoxCountry.Text = customerToLoad.country;
            guna2TextBoxCity.Text = customerToLoad.city;
        }

        private void FormUpdateCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnFormExit.Invoke(this, e);
        }
    }
}
