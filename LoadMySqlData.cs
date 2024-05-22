using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software2Csharp
{
    public class LoadMySqlData
    {
        public MySqlConnection cnn;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string sql = "SELECT * FROM user";
        public string myConnectionDatabaseString = "server=localhost;database=client_schedule;uid=root;pwd=Passw0rd!;Convert Zero Datetime=True;";

        public LoadMySqlData()
        {
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cmd = new MySqlCommand(sql, cnn);
            try
            {
                //cnn.Open();
                Console.WriteLine("Connection from load my sql data open.");
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
        public void LoadCustomerData(DataGridView dataGridView)
        {
            sql = "SELECT * FROM customer";
            cmd = new MySqlCommand(sql,cnn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            dataGridView.DataSource = bindingSource;
            
        }


    }
}
