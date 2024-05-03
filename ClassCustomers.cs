using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2Csharp
{
    public class ClassCustomers
    {
        public string name;
        public string address;
        public string phoneNumber;
        public bool active;
        public DateTime createdDate;
        public DateTime updatedDate;
        public string createdBy;
        public string updatedBy;
        public ClassCustomers() 
        {
            name = "NewCustomer" + 1;
            active = true;
            createdDate = DateTime.Now;
            updatedDate = DateTime.Now;
        }

        public static void addCustomer(ClassCustomers newCustomer)
        {

        }
        public static void removeCustomer(int customerID)
        {

        }
        public static void updateCustomer(int customerID)
        {

        }
    }

}
