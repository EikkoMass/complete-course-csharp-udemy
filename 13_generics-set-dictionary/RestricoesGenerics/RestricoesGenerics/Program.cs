using System.Globalization;
using RestricoesGenerics.Entities;
using RestricoesGenerics.Services;

namespace RestricoesGenerics;

public class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        
        Console.Write("Enter N: ");
        int quantity = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantity; i++)
        {
            string[] vect = Console.ReadLine().Split(",");
            string name = vect[0];
            double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
            
            list.Add(new Product(name, price));
        }
        
        CalculationService calculationService = new CalculationService();

        Console.WriteLine($"Max: ");
        Console.WriteLine(calculationService.Max(list));
        ;
    }
}