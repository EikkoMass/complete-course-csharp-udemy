using System.Globalization;
using ExercicioResolvido.Entities;

namespace ExercicioResolvido;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string filePath = Console.ReadLine();
        
        List<Product> products = new();
        
        using (StreamReader sr = File.OpenText(filePath))
        {
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(',');
                string name = line[0];
                double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                
                products.Add(new Product(name, price));
            }
        }

        var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
        Console.WriteLine($"Average price = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        
        // apenas precos abaixo da media
        var names = products.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}