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
        public event EventHandler onAppExit;
        public FormAppointmentMain()
        {
            InitializeComponent();

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
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

        private void FormAppointmentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            onAppExit.Invoke(this, e);
        }

        private void treeViewTabs_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void guna2ButtonCustomers_Click(object sender, EventArgs e)
        {
            Customers uc = new Customers();
            addUserControl(uc);
        }

        private void guna2ButtonAppointments_Click(object sender, EventArgs e)
        {
            Appointments uc = new Appointments();
            addUserControl(uc);
        }
    }
}
