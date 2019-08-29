using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCinema
{
    class Staff
    {
        readonly MySqlConnection connection;

        public Staff()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }
        public void Insert(string name, string email, string password)
        {
            try
            {

                string insert = "INSERT INTO staff(name,email,password) VALUES('" + name + "','" + email + "','" + password + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
