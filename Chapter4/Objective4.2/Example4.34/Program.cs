using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Example4._34
{
    // This example is not supposed to work and would throw and exception as there are not such databases. The example simply shows a specific approach
    class Program
    {
        static void Main(string[] args)
        {
            var task = UpdateRows();
        }

        public static async Task UpdateRows()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE People SET FirstName='John'", connection);
                await connection.OpenAsync();
                int numberOfUpdatedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Updated {0} rows", numberOfUpdatedRows);
            }
        }
    }
}
