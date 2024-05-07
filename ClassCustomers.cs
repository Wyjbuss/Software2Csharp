using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2Csharp
{

    public class ClassCustomers
    {
        //Database connection and sql cammand
        public MySqlConnection cnn;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public string sql = "SELECT * FROM user";
        public string myConnectionDatabaseString = "server=localhost;database=client_schedule;uid=root;pwd=Passw0rd!;";

        public int customerId;
        public string name;
        public string addressId;
        public string phoneNumber;
        public bool active;
        public DateTime createdDate;
        public DateTime updatedDate;
        public string createdBy;
        public string updatedBy;
        public ClassCustomers() 
        {
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cmd = new MySqlCommand(sql, cnn);

            name = "NewCustomer" + 1;
            active = true;
            createdDate = DateTime.Now;
            updatedDate = DateTime.Now;
        }

        public void addCustomer(ClassCustomers newCustomer)
        {
            sql = "INSERT INTO customer" +
                ("VALUES({0},{1},{2},{3},{4},{5},{6},{7})"
                ,newCustomer.customerId
                ,newCustomer.name
                ,newCustomer.addressId
                ,newCustomer.createdDate
                ,newCustomer.createdBy
                ,newCustomer.updatedDate
                ,newCustomer.updatedDate);
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }
        public void removeCustomer(int customerID)
        {

        }
        public void updateCustomer(int customerID)
        {

        }
    }

}
