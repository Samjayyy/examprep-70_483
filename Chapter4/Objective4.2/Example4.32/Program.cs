using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Example4._32
{
    // This example is not supposed to work and would throw and exception as there are not such databases. The example simply shows a specific approach
    class Program
    {
        static void Main(string[] args)
        {
            var task = SelectDataFromTable();
        }

        public static async Task SelectDataFromTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM People", connection);
                await connection.OpenAsync();

                SqlDataReader dataReader = await command.ExecuteReaderAsync();
                while (await dataReader.ReadAsync())
                {
                    string formatStringWithMiddleName = "Person ({0}) is named {1} {2} {3}";
                    string formatStringWithoutMiddleName = "Person ({0}) is named {1} {3}";
                    if (dataReader["middlename"] != null)
                    {
                        Console.WriteLine(formatStringWithoutMiddleName,
                            dataReader["id"],
                            dataReader["firstname"],
                            dataReader["lastname"]);
                    }
                    else
                    {
                        Console.WriteLine(formatStringWithMiddleName,
                            dataReader["id"],
                            dataReader["firstname"],
                            dataReader["middlename"],
                            dataReader["lastname"]);
                    }

                    dataReader.Close();
                }
            }
        }
    }
}
