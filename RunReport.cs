using MySql.Data.MySqlClient;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software2Csharp
{
    public class RunReport
    {
        // other varibales
        public int NumOfAppointmentTyples;
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
            sql = "SELECT count(distinct Type) FROM appointment " +
                  $"WHERE Start >= '{selectedYear}-{selectedMonth}-01' AND " +
                  $"Start < '{selectedYear}-{selectedMonth}-01' + interval 1 month;";
            
            // run the quiry and store answer in varable
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();
            cmd = new MySqlCommand(sql, cnn);
            // this is = to None because that is the value of the first line in the types of this month
            NumOfAppointmentTyples = int.Parse( cmd.ExecuteScalar().ToString()); // this will be a number
            cnn.Close();

            // spit out report into file that is the number of different appoint types
            string fileName = "NumOfAppointment.txt";
            string fileContent = $"Number of different types of appointments for this month of chosen day: {selectedDate}" +
                $"\nReport ran on: {DateTime.Now}" +
                $"\nNumber of different appointment times that month are: {NumOfAppointmentTyples}";

            File.WriteAllText(fileName, fileContent );

            // Then open that file
            Action<string> openFile = filePath =>
            {
                if (File.Exists(filePath))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true // open with default application
                        });
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine( $"An error occurred with opening the numOfAppointments file: {e.Message}");
                    }
                }else Console.WriteLine("The file does not exist");
            };

            openFile(fileName);
        }

        public void SceduleForEachUser()
        {

        }

        public void MyChoiceReport()
        {

        }
    }
}
