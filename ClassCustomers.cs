using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            sql = $"INSERT INTO customer VALUES({newCustomer.customerId}," +
                $"'{newCustomer.name}'," +
                $"{newCustomer.addressId}," +
                $"{newCustomer.active}," +
                $"'{newCustomer.createdDate.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{newCustomer.createdBy}'," +
                $"'{newCustomer.updatedDate.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"'{newCustomer.updatedBy}');";
            
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void removeCustomer(int customerID)
        {
            sql = $"SET FOREIGN_KEY_CHECKS=0; DELETE FROM customer WHERE customerId={customerID};";
            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();
            cmd = new MySqlCommand(sql, cnn);


            cmd.ExecuteNonQuery();
            //cmd.ExecuteScalar();
            sql = "SET FOREIGN_KEY_CHECKS=1;";
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void updateCustomer(ClassCustomers newCustomerInfo, int selectedCustomersIDToReplace)
        {
            updatedDate = DateTime.Now;
            sql = $"UPDATE customer " +
                $"SET customerId={newCustomerInfo.customerId}, " +
                $"customerName='{newCustomerInfo.name}'," +
                $"addressId=3, " +
                $"active={newCustomerInfo.active}," +
                $"lastUpdated='{newCustomerInfo.updatedDate.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"lastUpdatedBy='{newCustomerInfo.updatedBy+1}'" +
                $"WHERE customerId={selectedCustomersIDToReplace}";

            cnn = new MySqlConnection(myConnectionDatabaseString);
            cnn.Open();
            cmd = new MySqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }

}
