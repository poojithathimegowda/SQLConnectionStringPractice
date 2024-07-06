using Microsoft.Data.Sqlite;
using System.Text;

public class CustomerManager
{
    public string _connectionString;
    public CustomerManager(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public void CreatTable()
    {
        using (SqliteConnection connection = new SqliteConnection(_connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection opened successfully.");

                string createTableQuery = @"
                  CREATE TABLE IF NOT EXISTS Customers (
                   CustomerID INTEGER PRIMARY KEY,
                   Name TEXT,
                   Address TEXT,
                   Email TEXT,
                   PhoneNo TEXT
                );";

                using (SqliteCommand createTableCommand = new SqliteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }
    }
}