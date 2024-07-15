using Microsoft.Data.Sqlite;

public class Program
{
    public static void Main(string[] args)
    {
        string connectionString = "Data Source=C:\\poojitha\\Clients.db";
        Console.WriteLine("Hello, World!");
        Console.WriteLine(" Insert new Customer");
        Customer customer = new Customer();
        CustomerManager customerManager = new CustomerManager(connectionString);
       // customerManager.CreatTable();
       
        Console.WriteLine("ID ");
        customer.CustomerID = int.Parse(Console.ReadLine());
        Console.WriteLine(" name ");
        customer.Name = Console.ReadLine();
        Console.WriteLine(" Address");
        customer.Address = Console.ReadLine();
        Console.WriteLine(" Email");
        customer.Email = Console.ReadLine();
        Console.WriteLine(" Phone no.");
        customer.PhoneNo = Console.ReadLine();

        customerManager.InsertCustomer(customer);
    }
}

       