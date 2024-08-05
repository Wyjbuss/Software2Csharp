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

            // loop through rows and get the date time start and end times
            foreach (DataGridViewRow row in gridView.Rows)
            {
                // if things aren't null
                if (row.Cells[9].Value != null && row.Cells[10].Value != null)
                {
                    string utcTimeStringStart = row.Cells[9].Value.ToString();
                    string utcTimeStringEnd = row.Cells[10].Value.ToString();

                    if (DateTime.TryParse(utcTimeStringStart, out DateTime utcDateTimeStart) )
                    {
                        DateTime localDateTimeStart = utcDateTimeStart.ToLocalTime();
                        row.Cells[9].Value = localDateTimeStart.ToString("yyyy-MM-dd HH:mm:ss");

                        
                    }
                    if (DateTime.TryParse(utcTimeStringEnd, out DateTime utcDateTimeEnd))
                    {
                        DateTime localDateTimeEnd = utcDateTimeEnd.ToLocalTime();
                        row.Cells[10].Value = localDateTimeEnd.ToString("yyyy-MM-dd HH:mm:ss");
                    }
                }
            }

        }

    }
}
