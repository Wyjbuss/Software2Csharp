using System;
using System.Windows.Forms;

namespace Software2Csharp
{
    public partial class FormAddAppointment : Form
    {
        bool bool_NotOnSameDay = true;

        public event EventHandler Event_ClosedAddNewAppointment;
        public FormAddAppointment()
        {
            InitializeComponent();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {


            //handel the incorrect inputs
            if (AllAreaaNoErrors())
            {
                try
                {
                    if (SceduleFrom9_5_M_F())
                    {
                        if (SceduleFromMondayToFriday())
                        {
                            if (bool_NotOnSameDay)
                            {

                                // add the appointment
                                ClassAppointments newAppointment = new ClassAppointments();

                                //capture the inputs and add them to the newAppointment                      
                                newAppointment.title = guna2TextBoxTitle.Text;
                                newAppointment.description = guna2TextBoxDescription.Text;
                                newAppointment.location = guna2TextBoxLocation.Text;
                                newAppointment.contact = guna2TextBoxContact.Text;
                                newAppointment.url = guna2TextBoxURL.Text;
                                newAppointment.start = dateTimePickerStart.Value;
                                newAppointment.end = dateTimePickerEnd.Value;


                                newAppointment.addAppointment(newAppointment);

                                // add the appointment to the database
                                //newAppointment.addAppointment();

                                //close the form when completed
                                this.Close();
                            }

                        }
                        else Console.WriteLine("Error: can't ass appointment, day needs to be between Monday - Friday");

                    }
                    else Console.WriteLine("Error: can't add appointment, time needs to be between 9AM and 5PM");

                }
                catch (Exception)
                {

                    Console.WriteLine("Can't add appointment, invalid feilds");
                }


            }

        }

        private ClassAppointments AddInputsToAppointment(ClassAppointments newAppointment)
        {
            //capture the inputs and add them to the newAppointment
            newAppointment.title = guna2TextBoxTitle.Text;
            newAppointment.description = guna2TextBoxDescription.Text;
            newAppointment.location = guna2TextBoxLocation.Text;
            newAppointment.contact = guna2TextBoxContact.Text;
            newAppointment.url = guna2TextBoxURL.Text;
            newAppointment.start = dateTimePickerStart.Value;
            newAppointment.end = dateTimePickerEnd.Value;

            return newAppointment;



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

        private void FormAddAppointment_Load(object sender, EventArgs e)
        {

        }

        private bool SceduleFrom9_5_M_F()
        {
            TimeSpan currentTime = dateTimePickerStart.Value.TimeOfDay;
            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(17, 0, 0);
            if (currentTime < endTime && currentTime > startTime)
            {
                return true;
            }
            else return false;
        }

        private bool SceduleFromMondayToFriday()
        {
            DateTime currentDate = dateTimePickerStart.Value;
            if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;

            }
            else return true;
        }

        private void FormAddAppointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Event_ClosedAddNewAppointment.Invoke(this, e);
        }

        //public void NotOnSameDateTimeAsAnother(DataGridView DGV)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    try
        //    {
        //        DateTime valueToCompareToStart; 
        //        DateTime valueToCompareToEnd;

        //        DateTime currentDate = dateTimePickerStart.Value;
        //        // if start time is not within any other time and date
        //        if (/*currentDate.Date == valueToCompareToStart.Date*/)
        //        {
        //            // needs to
        //            if (currentDate.TimeOfDay < valueToCompareToStart.TimeOfDay || currentDate.TimeOfDay > valueToCompareToEnd.TimeOfDay)
        //            {
        //                bool_NotOnSameDay = true;
        //                Console.WriteLine("Time not in conflict, appointment sceduled!");
        //            }
        //            else { bool_NotOnSameDay = false; Console.WriteLine("Time of Day is in conflict with anoter"); }
        //        }
        //        else { bool_NotOnSameDay = true; Console.WriteLine("Not on a date as another appointment, appointment sceduled!"); }

        //        }
        //    catch (Exception)
        //    {
        //        bool_NotOnSameDay = false; 
        //        Console.WriteLine("Error: DateTime error");
        //    }
        // }
    }
}
