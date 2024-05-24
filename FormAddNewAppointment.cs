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

                // add the appointment to the database
                newAppointment.addAppointment(newAppointment);

            }

        }

        private bool AllAreaaNoErrors()
        {
            throw new NotImplementedException();
        }
    }
}
