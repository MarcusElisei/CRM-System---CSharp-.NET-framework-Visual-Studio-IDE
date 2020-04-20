using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DHubCRM
{
    class customerDbConn: dbConn
    {
        public void insertCustomer(string Name, string CusFName, string CusLName, string CusTelNum, string address, string city, string CusEmail, string country)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblCustomer` (`CustomerNumber`, `customerName`, `contactLastName`, `contactFirstName`, `phone`, `addressLine1`, `city`, `country`, `email`) VALUES (NULL,@customerName, @contactLastName, @contactFirstName, @phone, @addressLine1, @city, @country, @email);";
            comm.Parameters.AddWithValue("@customerName", Name);
            comm.Parameters.AddWithValue("@contactLastName", CusLName);
            comm.Parameters.AddWithValue("@contactFirstName", CusFName);
            comm.Parameters.AddWithValue("@phone", CusTelNum);
            comm.Parameters.AddWithValue("@addressLine1", address);
            comm.Parameters.AddWithValue("@city", city);
            comm.Parameters.AddWithValue("@country", country);
            comm.Parameters.AddWithValue("@email", CusEmail);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateCustomer(String customerNumber, string Name, string CusFName, string CusLName, string CusTelNum, string address, string city, string CusEmail, string country)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblCustomer` SET `customerName`=@customerName,`contactLastName`=@contactLastName,`contactFirstName`=@contactFirstName," +
                "`phone`=@phone,`addressLine1`=@addressLine1, `city`=@city, `country`=@country, `email`=@email WHERE customerNumber=@customerNumber";
            comm.Parameters.AddWithValue("@customerName", Name);
            comm.Parameters.AddWithValue("@contactLastName", CusLName);
            comm.Parameters.AddWithValue("@contactFirstName", CusFName);
            comm.Parameters.AddWithValue("@phone", CusTelNum);
            comm.Parameters.AddWithValue("@addressLine1", address);
            comm.Parameters.AddWithValue("@city", city);
            comm.Parameters.AddWithValue("@country", country);
            comm.Parameters.AddWithValue("@email", CusEmail);
            comm.Parameters.AddWithValue("@customerNumber", customerNumber);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteCustomer(string CusID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblCustomer` WHERE customerNumber = @customerNumber";
            comm.Parameters.AddWithValue("@customerNumber", CusID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
