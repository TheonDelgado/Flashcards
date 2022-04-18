using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Flashcards
{
    internal class DbManager
    {
        private static string connectionString = "Data Source=DESKTOP-ID2OLH7;Integrated Security = True";

        public static void IntializeDatabase()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed! :(");
                    Console.WriteLine(ex.Message);
                }

                string queryString = @"CREATE TABLE Test(
                                        Id int AUTO_INCREMENT,
                                        Name varchar(20)
                                        );";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
