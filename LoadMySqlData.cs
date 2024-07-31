using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Jenga.Theme;

namespace Software2Csharp
{
    public class LoadMySqlData
    {
        public MySqlConnection cnn;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string sql = "SELECT * FROM user";
        public static string myConnectionDatabaseString = "server=localhost;database=client_schedule;uid=root;pwd=Passw0rd!;Convert Zero Datetime=True;";

        public LoadMySqlData()
        {
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cmd = new MySqlCommand(sql, cnn);
            
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

        public void LoadAppointmentDataIntoGridView(DataGridView gridView)
        {
            sql = "SELECT * FROM appointment";
            cmd = new MySqlCommand(sql, cnn);


            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            gridView.DataSource = bindingSource;

        }
        public void LoadAppointmentDataIntoGridView(DataGridView gridView, DateTime startDate)
        {
            sql = $"select * from appointment WHERE DATE(start) = DATE('{startDate.Year}-{startDate.Month}-{startDate.Day}');";
            cmd = new MySqlCommand(sql, cnn);


            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            gridView.DataSource = bindingSource;

        }

    }
}
