using MySqlConnector;
using System;
using System.Windows.Forms;

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
        public DateTime start { get; set; }
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
            description = "None";

            start = DateTime.Now;
            end = DateTime.Now;

            cnn.Close();

        }

        public void addAppointment(ClassAppointments appointment)
        {
            try
            {


                //ClassAppointments appointment = this;
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
                Console.WriteLine($"added appointment with a position of {appointmentId}");
            }
            catch (Exception)
            {

                Console.WriteLine("Failed to add new appointment");
            }

        }

        public void removeAppointment(int AppointmentID)
        {
            try
            {

                //delete appointment
                sql = $"DELETE FROM appointment WHERE appointmentId='{AppointmentID}';";

                // create the connection and assign the sql to the command
                cnn = new MySqlConnection(myConnectionDatabaseString);
                cmd = new MySqlCommand(sql, cnn);

                // open the connection
                cnn.Open();

                //run the command 
                cmd.ExecuteNonQuery();

                // close the connection
                cnn.Close();

                Console.WriteLine($"Appointment deleted at position {AppointmentID}");
            }
            catch (Exception)
            {

                Console.WriteLine("Cant remove appointment");
            }

        }

        public void updateAppointment(int AppointmentID, ClassAppointments updatedInfo)
        {
            // get the current appointment by ID and update the data

            // the datetime that this was last updated by
            updatedInfo.lastUpdate = DateTime.Now;

            // the eql command that will update the datebase
            sql = $"UPDATE appointment " +
                $"SET " +
                $"customerId={updatedInfo.customerId}," +
                $"userId={updatedInfo.userId}, " +
                $"title='{updatedInfo.title}'," +
                $"description='{updatedInfo.description}'," +
                $"location='{updatedInfo.location}'," +
                $"contact='{updatedInfo.contact}'," +
                $"type='{updatedInfo.type}'," +
                $"url='{updatedInfo.url}'," +
                $"start='{updatedInfo.start.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"end='{updatedInfo.end.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"lastUpdate='{updatedInfo.lastUpdate.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"lastUpdateBy='{updatedInfo.lastUpdateBy}'" +
                $"WHERE appointmentId={appointmentId}";


            // create the connection and assign the sql to the command
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cmd = new MySqlCommand(sql, cnn);

            // open the connection
            cnn.Open();

            //run the command 
            cmd.ExecuteNonQuery();

            // close the connection
            cnn.Close();

        }

        public void FindTimesOfAppointments(DataGridView DGV)
        {
            try
            {
                if (DGV.Rows == null || DGV.Rows.Count == 0)
                {
                    Console.WriteLine("Data grid view is empty or null");

                }
                else
                {
                    // loop through the datagridview and addign the vale to compair to the date of each 
                    foreach (DataGridViewRow row in DGV.Rows)
                    {
                        // this is the index of the start time of the appointment
                        String valueToCompareToStart = row.Cells[9].Value.ToString();

                        //String valueToCompareToEnd = row.Cells[10].Value.ToString();

                        try
                        {
                            if (DateTime.Now.Date == DateTime.Parse(valueToCompareToStart).Date)
                            {
                                //if true then run the timer 15min function and pass the time
                                Notification notification = new Notification();
                                //notification.Notifications(DateTime.Parse(valueToCompareToStart));
                                bool hasBeennotifyed = notification.Notifications(DateTime.Parse(valueToCompareToStart));                                
                                if (hasBeennotifyed) { break; }
                                //Console.WriteLine($"Checked item {row.Index}");
                                //Console.WriteLine("Time not in conflict, appointment sceduled!");
                                //return true;
                                continue;

                            }
                            else
                            {
                                Console.WriteLine("Time of Day is in conflict with anoter");

                            }

                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Time day could not be found or it is null");

                        }

                    }
                    // after the loop is successfull then return true


                }

            }
            catch (Exception)
            {

                Console.WriteLine("Data Grid View is non existant or null program error");

            }



        }
    }


}
