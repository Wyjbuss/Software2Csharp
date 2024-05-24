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
        public Appointments()
        {
            InitializeComponent();
            //load the appointments into the monthCalendar
        }

        private void guna2ButtonCreateNewAppointment_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendarAppointments_DateSelected(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine(monthCalendarAppointments.SelectionRange.Start.ToString());
        }
    }
}
