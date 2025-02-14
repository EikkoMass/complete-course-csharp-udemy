using System.Globalization;
using SolucaoSemInterface.Entities;

namespace SolucaoSemInterface;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data");
        string model = (string) Console.ReadLine();
        Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        
        CarRental rental = new CarRental(start, finish, new Vehicle(model));
        
    }
}