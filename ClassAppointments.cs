using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2Csharp
{
    public class ClassAppointments
    {
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
            title = "newAppointmentTitle" + 1;
        }

        public static void addAppointment(ClassAppointments appointment)
        {
            // create database entry and add the data in this appointment 
        }

        public static void removeAppointment(int AppointmentID) 
        {

        }

        public static void updateAppointment(int AppointmentID) 
        {
            // get the current appointment by ID and update the data
        }
    }

   
}
