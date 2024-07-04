using Microsoft.Data.Sqlite;

public class Program
{
    public static void Main(string[] args)
    {
        string connectionString = "Data Source=C:\\projects\\Customer.db";
        Console.WriteLine("Hello, World!");
        CustomerManager customerManager = new CustomerManager(connectionString);
        customerManager.CreatTable();
    }
}

       