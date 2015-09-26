using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;

namespace Example4._36
{
    // This example is not supposed to work and would throw and exception as there are not such databases. The example simply shows a specific approach
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void DoTransaction()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ProgrammingCSharpConnection"].ConnectionString;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command1 = new SqlCommand("INSERT INTO People ([FirstName], [LastName], [MiddleInitial]) VALUES('John', 'Doe', 'null')", connection);
                    SqlCommand command2 = new SqlCommand("INSERT INTO People ([FirstName], [LastName], [MiddleInitial]) VALUES('Jane', 'Doe', 'null')", connection);

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }

                transactionScope.Complete();
            }
        }
    }
}
