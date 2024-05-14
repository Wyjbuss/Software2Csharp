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
            createdBy = "ME";
            updatedBy = "ME";
            phoneNumber = string.Empty;
            addressId = 1;
            sql = "SELECT COUNT(*) FROM customer";
            customerId = cmd.ExecuteNonQuery()+1;
            cnn.Close();

        }

        public void addCustomer(ClassCustomers newCustomer)
        {
            createdDate = DateTime.Now;
            updatedDate = DateTime.Now;
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();
            sql = $"INSERT INTO customer VALUES({newCustomer.customerId},'{newCustomer.name}',{newCustomer.addressId},{newCustomer.active},{newCustomer.createdDate.ToString("MM / dd / yyyy ")},'{newCustomer.createdBy}',{newCustomer.updatedDate.ToString("MM / dd / yyyy ")},'{newCustomer.updatedBy}');";
            //sql = "insert into customer values(4, 'Jane Pain', 3, 1, 5 / 7 / 2024, 'Me', 5 / 7 / 2024, 'Me');";
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void removeCustomer(int customerID)
        {
            sql = $"DELETE FROM customer WHERE customerId={customerID.ToString()}";
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void updateCustomer(int customerID)
        {

        }
    }

}
