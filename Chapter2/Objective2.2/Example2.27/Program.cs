using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;

namespace Example2._27
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Throw sql Exception");
                throw new InvalidOperationException("You can not do so");
            }
            catch (Exception ex)
            {
                if(ex is Exception)
                {
                    Console.WriteLine("exception is just an exception");
                }
                if (ex is InvalidOperationException)
                {
                    Console.WriteLine("exception is of type invalidoperationException");
                }
                var sqlEx = ex as SqlException;
                if(sqlEx != null)
                {
                    Console.WriteLine($"Sql Error code = {sqlEx.ErrorCode}");
                }else
                {
                    Console.WriteLine("We are not handling a sql exception");
                }
            }
            Console.ReadKey();
        }

        void OpenConnection(DbConnection connection)
        {
            if (connection is SqlConnection)
            {
                // run some special code
            }
        }

        void LogStream(Stream stream)
        {
            MemoryStream memoryStream = stream as MemoryStream;
            if (memoryStream != null)
            {
                // ...
            }
        }
    }
}
