using System;

namespace Software2Csharp
{

    internal class Notification
    {
        FormNotification_15minBefore FormNotify;
        public bool Notifications(DateTime appointmentTime)
        {
            if (appointmentTime == null)
            {

                Console.WriteLine("appointment time is invalid to notification");
                return false;
            }

            // if the time that it is now minus the appointment time is 15 min or less
            else if ( appointmentTime.TimeOfDay - DateTime.Now.TimeOfDay < TimeSpan.FromMinutes(15))
            {
                FormNotify = new FormNotification_15minBefore();

                FormNotify.Show();
                return true;
            }
            else { Console.WriteLine("invalid date time form ntification script"); return false; }
        }

    }
}
