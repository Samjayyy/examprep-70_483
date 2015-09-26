using System.Configuration;
using System.Data.SqlClient;

namespace Example4._30
{
    // This example is not supposed to work and would throw and exception as there are not such databases. The example simply shows a specific approach
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingCSharpConnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }
    }
}
