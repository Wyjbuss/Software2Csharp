﻿using System;
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
using MySql.Data.MySqlClient;
using System.Web;
using System.IO;

namespace Software2Csharp
{
    public partial class FormLogin : Form
    {
        string locationNameContryCode;
        string logLoginPath = @"./Login_History.txt";
        FormAppointmentMain formAppointmentMain;
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        string usrName;
        string usrPwd;
        string sql = "SELECT * FROM user";
        public static string myConnectionDatabaseString = "server=localhost;database=client_schedule;uid=root;pwd=Passw0rd!;";
        public FormLogin()
        {
            InitializeComponent();
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cmd = new MySqlCommand(sql, cnn);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open.");
                dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    usrName += $"{dr.GetString("userName")};";
                //    usrPwd += $"{dr.GetString("password")};";
                //}
                
                //Console.WriteLine("Username: {0} Password: {1}",usrName,usrPwd);
                //cnn.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Cannot open connection.");
            }
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
            labelErrorText.Text = "Incorrect login";
        }
        private void spanishLanguage()
        {
            labelLogin.Text = "Acceso";
            labelPassword.Text = "Contraseña:";
            labelUsername.Text = "Nombre de usuario:";
            buttonLogin.Text = "Acceso";
            labelErrorText.Text = "Inicio de sesión incorrecto";
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // check the input feilds have no errors
            if (loginInputsNoErrors())
            {
                while (dr.Read())
                {
                    usrName += $"{dr.GetString("userName")};";
                    usrPwd += $"{dr.GetString("password")};";
                }
                
                // execute login is correct check with database
                if (checkLoginSuccess())
                {
                    
                    // login here, open new page, stay signed in
                    CreateFormUsrLogin(usrName);

                }
                else
                {
                    if (domainUpDownLocation.Text == "English")
                    {
                        createLoginErrorMessage("Wrong Username or Password. Try Again.");
                    }
                    else if (domainUpDownLocation.Text == "Spanish")
                    {
                        createLoginErrorMessage("Nombre de usuario o contraseña incorrectos. Vuelve a intentarlo.");
                    }
                     
                }
            }
            else
            {
                // error display that feild is empty or invalid
                if (domainUpDownLocation.Text == "English")
                {
                    createLoginErrorMessage("Login fields are empty or invalid.");
                }
                else if (domainUpDownLocation.Text == "Spanish")
                {
                    createLoginErrorMessage("Los campos de inicio de sesión están vacíos o no son válidos.");
                }
                
                
            }
        }

        private void CreateFormUsrLogin(string userName)
        {
            
            formAppointmentMain = new FormAppointmentMain();
            formAppointmentMain.setLabelHelloUsr("Hello, "+ userName);
            formAppointmentMain.Show();
            Console.WriteLine("Logging in: {0}", userName);
            cnn.Close();
            formAppointmentMain.onAppExit += Frm_onAppExit;
            this.Hide();

            //log the user logging in
            createSigninLog(userName);
        }

        private void Frm_onAppExit( object sender, EventArgs e)
        {
            formAppointmentMain.onAppExit -= Frm_onAppExit;
            this.Close();
        }

        private void createSigninLog(string usr)
        {
            if (!string.IsNullOrEmpty(usr))
            {
                if (!File.Exists(logLoginPath))
                {
                    //create the file
                    using (StreamWriter sw = File.CreateText(logLoginPath))
                    {
                        // write the log here
                        sw.WriteLine("Logged in as: {0} on/at {1}",usr,DateTime.Now);
                    }
                }
                else
                {

                using (StreamWriter sw = File.AppendText(logLoginPath))
                {
                    // write the log here
                    sw.WriteLine("Logged in as: {0} on/at {1}", usr, DateTime.Now);
                }
                }
            }
        }

        private bool loginInputsNoErrors()
        {
            if (textBoxUsername.Text != null || textBoxUsername.Text != "" || textBoxPassword.Text != null || textBoxPassword.Text !="")
            {
                return true;
            }
            else return false;
        }

        private void createLoginErrorMessage(string message)
        {
            labelErrorText.Text = message;
            labelErrorText.Visible = true;
        }

        /// <summary>
        /// returns true if login entered (username & password) matches in the database
        /// </summary>
        /// <returns>true if login entered (username & password) matches in the database</returns>
        private bool checkLoginSuccess()
        {
            // if login check with database is success the return true
            if (textBoxPassword.Text+";" == usrPwd && textBoxUsername.Text+";" == usrName)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void buttonLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
