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
    public partial class FormAddNewCustomer : Form
    {
        public FormAddNewCustomer()
        {
            InitializeComponent();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            // check that fields are not empty and are "trimmed"
            if (noEmptyFields() && phoneNumberHasNoErrors())
            {
                // process adding the user
                ClassCustomers newCustomer = new ClassCustomers();
                newCustomer.phoneNumber = "123-456-7890";
                newCustomer.addCustomer(newCustomer);
            }
            else Console.Error.WriteLine("Feilds are incorect to create new customer");
        }

        private bool phoneNumberHasNoErrors()
        {
            if (guna2TextBoxPhoneNumber.Text.All(char.IsDigit) || guna2TextBoxPhoneNumber.Text.Contains("-"))
            {
                return true;
            }
            else return false;
        }

        private bool noEmptyFields()
        {
            if (guna2TextBoxName.Text.Length > 0 && guna2TextBoxAddress.Text.Length > 0 && guna2TextBoxPhoneNumber.Text.Length > 0 && guna2TextBoxPostalCode.Text.Length > 0 && guna2TextBoxCountry.Text.Length > 0 && guna2TextBoxCity.Text.Length > 0)
            {
                return true;
            }
            else return false;
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
