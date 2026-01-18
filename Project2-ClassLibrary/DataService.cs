using System;
using Microsoft.Data.SqlClient;


namespace Project2_ClassLibrary
{
    public class DataService
    {
        private readonly string _connectionString;
        
        public DataService(string connectionString)
        {
            _connectionString = connectionString;
        }
        
        public void TestConnection()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                Console.WriteLine("Connection successful!");
            }
        }
    }
}
