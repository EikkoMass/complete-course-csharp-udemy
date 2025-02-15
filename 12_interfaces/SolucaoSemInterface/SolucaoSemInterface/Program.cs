using System.Globalization;
using SolucaoSemInterface.Entities;
using SolucaoSemInterface.Services;

namespace SolucaoSemInterface;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter rental data: ");
        string model = (string) Console.ReadLine();
        
        Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Enter price per hour: ");
        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Enter price per day: ");
        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        CarRental rental = new CarRental(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(hour, day);
        rentalService.ProcessInvoice(rental);

        Console.WriteLine("Invoice: ");
        Console.WriteLine(rental.Invoice);
    }
}