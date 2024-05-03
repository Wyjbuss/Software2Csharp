using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2Csharp
{
    public class ClassAppointments
    {
        public enum appointmentType { }
        public string title;
        public string description;
        public string location;
        public DateTime startTime;
        public DateTime endTime;
        public DateTime lastUpdated;
        public string lastUpdaedBy;
        public DateTime createdDate;
        public string createdBy;
        public string url;

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
