using Microsoft.Data.Sqlite;
using System.Text;

public class CustomerManager
{
    public string _connectionString;
    public CustomerManager(string connectionString)
    {
        _connectionString = connectionString;
    }
    Customer customers =new Customer();
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

    public void InsertCustomer(Customer customer)
    {
        using (SqliteConnection connection = new SqliteConnection(_connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection opened successfully.");

                StringBuilder insertDataQuery = new StringBuilder();
                insertDataQuery.Append("INSERT INTO Customers (CustomerID,Name, Address, Email,PhoneNo) ");
                insertDataQuery.AppendFormat("VALUES ({0}, '{1}', {2},'{3}','{4}');", customers.CustomerID, customers.Name, customers.Address,customers.Email,customers.PhoneNo);

                using (SqliteCommand createTableCommand = new SqliteCommand(insertDataQuery.ToString(), connection))
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