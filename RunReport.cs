using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Software2Csharp
{
    public class RunReport
    {
        // other varibales
        public object monthOfAppointments;
        // connection info
        public MySqlConnection cnn;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string sql = "SELECT COUNT(*) FROM appointment";
        public string myConnectionDatabaseString = "server=localhost;database=client_schedule;uid=root;pwd=Passw0rd!;";
        
        // input the month to run it for
        public void AppointmentTypesByMonth(DateTime selectedDate)
        {
            // quiry for the month that is currentlly selected adn get the type
            string selectedYear = selectedDate.Year.ToString();
            string selectedMonth = selectedDate.Month.ToString();
            sql = "SELECT Type FROM appointment " +
                  $"WHERE Start >= '{selectedYear}-{selectedMonth}-01' AND " +
                  $"Start < '{selectedYear}-{selectedMonth}-01' + interval 1 month;";
            
            // run the quiry and store answer in varable
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();
            cmd = new MySqlCommand(sql, cnn);
            // this is = to None because that is the value of the first line in the types of this month
            monthOfAppointments = cmd.ExecuteScalar();
            cnn.Close();

            // spit out report into file that is the number of different appoint types


            // Then open that file

        }

        public void SceduleForEachUser()
        {

        }

        public void MyChoiceReport()
        {

        }
    }
}
