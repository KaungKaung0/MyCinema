using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCinema
{
    class Authentication
    {
        public string Auth(string email, string password)
        {
            string status = "wemail";
            try
            {
                string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
                MySqlConnection conn = new MySqlConnection(entry);
                string query = "SELECT email,password FROM staff WHERE email='" + email + "'";
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["password"].ToString() == password)
                    {
                        status = "approved";
                    }
                    else if (reader["email"].ToString() == email && reader["password"].ToString() != password)
                    {
                        status = "wpass";
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return status;
        }

    }
}
