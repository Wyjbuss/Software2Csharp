using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2Csharp
{
    public class ClassAppointments
    {
        public MySqlConnection cnn;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string sql = "SELECT COUNT(*) FROM appointment";
        public string myConnectionDatabaseString = "server=localhost;database=client_schedule;uid=root;pwd=Passw0rd!;";


        public int appointmentId;
        public int customerId;
        public int userId;
        public string title;
        public string description;
        public string location;
        public string contact;
        public string type;
        public string url;
        public DateTime start;
        public DateTime end;
        public DateTime createdDate;
        public string createdBy;
        public DateTime lastUpdate;
        public string lastUpdateBy;
       

        // link to customer

        //get current appointments and prevent from setting one that overlaps
        public ClassAppointments() 
        {
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();

            sql = "SELECT COUNT(*) FROM appointment";
            cmd = new MySqlCommand(sql, cnn);

            appointmentId = cmd.ExecuteNonQuery() + 1;
            title = $"newAppointmentTitle {appointmentId.ToString()}";
            
            customerId = 0; userId = 0;
            url = "None";
            createdBy = "test";
            lastUpdateBy = "test";
            type = "None";
            contact = "None";
            location = "None";
            description ="None";

            start = DateTime.Now;
            end = DateTime.Now;

            cnn.Close();
             
        }

        public void addAppointment()
        {
            ClassAppointments appointment = this;
            cnn = new MySqlConnection(myConnectionDatabaseString);
            sql = $"SET FOREIGN_KEY_CHECKS=0;";
            
            cmd = new MySqlCommand(sql, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();

            createdDate = DateTime.Now;
            lastUpdate = DateTime.Now;
            
            // create database entry and add the data in this appointment 

            sql = $"INSERT INTO appointment VALUES({appointment.appointmentId}," +
                $"{appointment.customerId}," +
                $"{appointment.userId}," +
                $"'{appointment.title}'," +
                $"'{appointment.description}'," +
                $"'{appointment.location}'," +
                $"'{appointment.contact}'," +
                $"'{appointment.type}'," +
                $"'{appointment.url}'," +
                $"'{appointment.start.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{appointment.end.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{appointment.createdDate.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{appointment.createdBy}'," +
                $"'{appointment.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{appointment.lastUpdateBy}');";

            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();

            sql = "SET FOREIGN_KEY_CHECKS=1;";
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public void removeAppointment(int AppointmentID) 
        {

        }

        public void updateAppointment(int AppointmentID) 
        {
            // get the current appointment by ID and update the data
        }
    }

   
}
