using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software2Csharp
{
    public partial class Appointments : UserControl
    {
        public FormAddAppointment newAppointmentForm;
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
            DateTime startDate = monthCalendarAppointments.SelectionRange.Start;
            Console.WriteLine(startDate);

            // load that data that is on that date
            LoadMySqlData loadMySqlData = new LoadMySqlData();
            loadMySqlData.LoadAppointmentDataIntoGridView(guna2DataGridViewAppointments);
        }

        private void monthCalendarAppointments_DateChanged(object sender, DateRangeEventArgs e)
        {
        //    DateTime startDate = monthCalendarAppointments.SelectionRange.Start;
        //    Console.WriteLine(startDate);

        //    // load that data that is on that date
        //    LoadMySqlData loadMySqlData = new LoadMySqlData();
        //    loadMySqlData.LoadAppointmentDataIntoGridView(guna2DataGridViewAppointments);
        }
    }
}
