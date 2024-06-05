using ServiceStack.Text;
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
    public partial class FormAddAppointment : Form
    {
        public FormAddAppointment()
        {
            InitializeComponent();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            //handel the incorrect inputs
            if (AllAreaaNoErrors())
            {
                // add the appointment
                ClassAppointments newAppointment = new ClassAppointments();

                //capture the inputs and add them to the newAppointment
                AddInputsToAppointment(newAppointment);

                // add the appointment to the database
                newAppointment.addAppointment(newAppointment);

            }

        }

        private void AddInputsToAppointment(ClassAppointments newAppointment)
        {
            //capture the inputs and add them to the newAppointment
            guna2TextBoxTitle.Text = newAppointment.title;
            guna2TextBoxDescription.Text = newAppointment.description;
            guna2TextBoxLocation.Text = newAppointment.location;
            guna2TextBoxContact.Text = newAppointment.contact;
            guna2TextBoxURL.Text = newAppointment.url;
            //dateTimePickerStart.Value = newAppointment.start;
            //dateTimePickerEnd.Value = newAppointment.end;

            
        }

        private bool AllAreaaNoErrors()
        {
            return true;
            throw new NotImplementedException("Have not implimented input checking on adding appointment form");
        }

        private void guna2ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
