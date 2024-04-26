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
    public partial class FormAppointmentMain : Form
    {
        public FormAppointmentMain()
        {
            InitializeComponent();
        }

        private void FormAppointmentMain_Load(object sender, EventArgs e)
        {

        }

        public void setLabelHelloUsr(string usr)
        {
            labelHelloUsr.Text = usr;
        }
        public void closeApp()
        {

        }
    }
}
