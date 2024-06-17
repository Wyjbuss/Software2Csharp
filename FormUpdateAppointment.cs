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
    public partial class FormUpdateAppointment : Form
    {
        ClassAppointments newAppointment; 
        public FormUpdateAppointment()
        {
            InitializeComponent();
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ButtonUpdate_Click(object sender, EventArgs e)
        {
            // collect all the feilds on this form and add them to a new appointment

            // create new appointment 
            newAppointment = new ClassAppointments();

            // get all the feilds of this form and add it to the new appointment
            newAppointment.customerId  = 1;
            newAppointment.userId      = 0;
            newAppointment.title       = this.guna2TextBoxTitle.Text;
            newAppointment.description = this.guna2TextBoxDescription.Text;
            newAppointment.location    = this.guna2TextBoxLocation.Text;
            newAppointment.contact     = this.guna2TextBoxContact.Text;
            newAppointment.type        = this.guna2TextBoxType.Text;
            newAppointment.url         = this.guna2TextBoxURL.Text;
            newAppointment.start       = this.dateTimePickerStart.Value;
            newAppointment.end         = this.dateTimePickerEnd.Value;

        }
    }
}
