using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;

namespace Software2Csharp
{
    public partial class FormLogin : Form
    {
        string locationNameContryCode;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // returns the 2 letter country code
            locationNameContryCode = RegionInfo.CurrentRegion.Name;
            //RegionInfo reginInfo = new RegionInfo("US");
            domainUpDownLocation.Text = "Spanish";
            if (locationNameContryCode != null || locationNameContryCode != "Undefined")
            {
                // execute this if we have a region
                Console.WriteLine("The regin that you are in is: " + locationNameContryCode);
                convertRegionToLanguage();

            }
            else { Console.WriteLine("Region is not fround on form load. Default to US."); locationNameContryCode = "US"; }
        }

        private void convertRegionToLanguage()
        {
            if (locationNameContryCode == "US" )
            {
                domainUpDownLocation.Text = "English";
                englishLanguage();
                
            }
            else if (locationNameContryCode == "MX" )
            {
                domainUpDownLocation.Text = "Spanish";
                spanishLanguage();
            }
        }
        private void englishLanguage()
        {
            labelLogin.Text = "Login";
            labelPassword.Text = "Password:";
            labelUsername.Text = "Username:";
            buttonLogin.Text = "Login";
        }
        private void spanishLanguage()
        {
            labelLogin.Text = "Acceso";
            labelPassword.Text = "Contraseña:";
            labelUsername.Text = "Nombre de usuario:";
            buttonLogin.Text = "Acceso";
        }

        private void domainUpDownLocation_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDownLocation.Text == "English")
            {
                englishLanguage();
            }
            else if (domainUpDownLocation.Text == "Spanish")
            {
                spanishLanguage();
            }
        }
    }
}
