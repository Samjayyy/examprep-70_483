using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Example4._35
{
    // This example is not supposed to work and would throw and exception as there are not such databases. The example simply shows a specific approach
    class Program
    {
        static void Main(string[] args)
        {
            var task = InsertRowWithParameterizedQuery();
        }

        public static async Task InsertRowWithParameterizedQuery()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO People([FirstName], [LastName], [MiddleName]) VALUES(@firstName, @lastName, @middleName)", connection);
                await connection.OpenAsync();

                command.Parameters.AddWithValue("@firstName", "John");
                command.Parameters.AddWithValue("@lastName", "Doe");
                command.Parameters.AddWithValue("@middleName", "Little");

                int numberOfInsertedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Inserted {0} rows", numberOfInsertedRows);
            }
        }
    }
}
