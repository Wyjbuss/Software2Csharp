using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
        public string sql = "SELECT * FROM customer";
        public string myConnectionDatabaseString = "server=localhost;database=client_schedule;uid=root;pwd=Passw0rd!;";

        private int customerId;
        public string name;
        public string address;
        public int addressId;
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
            cnn.Open();

            name = "NewCustomer" + 1;
            active = true;
            createdDate = DateTime.Now;
            updatedDate = DateTime.Now;
            createdBy = "";
            updatedBy = "";
            phoneNumber = string.Empty;
            addressId = 1;
            customerId = 4;
            cnn.Close();

        }

        public void addCustomer(ClassCustomers newCustomer)
        {
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();
            //sql = $"INSERT INTO customer VALUES({newCustomer.customerId},{newCustomer.name},{newCustomer.addressId},{newCustomer.active},{newCustomer.createdDate.ToString("yyyy-MM-dd HH:mm:ss")},{newCustomer.createdBy},{newCustomer.updatedDate.ToString("yyyy-MM-dd HH:mm:ss")},{newCustomer.updatedBy});";
            sql = "insert into customer values(4, 'Jane Pain', 3, 1, 5 / 7 / 2024, 'Me', 5 / 7 / 2024, 'Me');";
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void removeCustomer(int customerID)
        {

        }
        public void updateCustomer(int customerID)
        {

        }
    }

}
