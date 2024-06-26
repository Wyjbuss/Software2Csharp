using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software2Csharp
{
    public partial class Appointments : UserControl
    {
        public FormAddAppointment newAppointmentForm;
        public FormUpdateAppointment newUpdateAppointment;

        // the date the the user selects on the calendar
        public DateTime startDate;
        public Appointments()
        {
            InitializeComponent();
            //load the appointments into the monthCalendar
        }

        private void guna2ButtonCreateNewAppointment_Click(object sender, EventArgs e)
        {
            newAppointmentForm = new FormAddAppointment();
            newAppointmentForm.Show();
        }

        private void monthCalendarAppointments_DateSelected(object sender, DateRangeEventArgs e)
        {
            // get the date
            startDate = monthCalendarAppointments.SelectionRange.Start.Date;
            Console.WriteLine($"{startDate.Month}-{startDate.Day}-{startDate.Year}");

            // load that data that is on that date
            LoadMySqlData loadMySqlData = new LoadMySqlData();
            loadMySqlData.LoadAppointmentDataIntoGridView(guna2DataGridViewAppointments,startDate);
        }

        private void monthCalendarAppointments_DateChanged(object sender, DateRangeEventArgs e)
        {
        //    DateTime startDate = monthCalendarAppointments.SelectionRange.Start;
        //    Console.WriteLine(startDate);

        //    // load that data that is on that date
        //    LoadMySqlData loadMySqlData = new LoadMySqlData();
        //    loadMySqlData.LoadAppointmentDataIntoGridView(guna2DataGridViewAppointments);
        }

        private void guna2ButtonUpdateAppointment_Click(object sender, EventArgs e)
        {

            try
            {
            var obj = guna2DataGridViewAppointments.SelectedRows[0];
            string appointmentId = obj.Cells[0].Value.ToString();
            string customerId = obj.Cells[1].Value.ToString();
            string userId = obj.Cells[2].Value.ToString();
            string title = obj.Cells[3].Value.ToString();
            string description = obj.Cells[4].Value.ToString();
            string location = obj.Cells[5].Value.ToString();
            string contact = obj.Cells[6].Value.ToString();
            string type = obj.Cells[7].Value.ToString();
            string URL = obj.Cells[8].Value.ToString();
            string start = obj.Cells[9].Value.ToString();
            string end = obj.Cells[10].Value.ToString();
            string createDate = obj.Cells[11].Value.ToString();
            string createBy = obj.Cells[12].Value.ToString();
            string lastUpdate = obj.Cells[13].Value.ToString();
            string lastUpdateBy = obj.Cells[14].Value.ToString();

                newUpdateAppointment = new FormUpdateAppointment(appointmentId, customerId, userId, title, description, location, contact, type, URL, start, end, createDate, createBy, lastUpdate, lastUpdateBy);

                // set the feilds to = the values from this


                newUpdateAppointment.Show();
                newUpdateAppointment.Event_UpdateAppointmentFormClose += UpdateApplicationData;
            }
            catch (Exception)
            {
                Console.WriteLine("unable to show update appointment form: Maybe try selecting a date and an appointment");
                throw;
            }

          

        }

        private void UpdateApplicationData(object sender, EventArgs e)
        {
            //refesh data
            // load that data that is on that date
            LoadMySqlData loadMySqlData = new LoadMySqlData();
            loadMySqlData.LoadAppointmentDataIntoGridView(guna2DataGridViewAppointments, startDate);

            // un subscribe
            newUpdateAppointment.Event_UpdateAppointmentFormClose -= UpdateApplicationData;
        }
    }
}
