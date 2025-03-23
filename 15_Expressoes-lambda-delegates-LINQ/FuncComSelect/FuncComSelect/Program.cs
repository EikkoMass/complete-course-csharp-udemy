using FuncComSelect.Entities;

namespace  FuncComSelect;

public class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new()
        {
            new Product("Tv", 900.00),
            new Product("Mouse", 50.00),
            new Product("Tablet", 350.50),
            new Product("HD Case", 80.90)
        };
        
        // Func<Product, string> nameUpper = NameUpper;
        Func<Product, string> nameUpper = p => p.Name.ToUpper();
        
        list.Select(nameUpper).ToList().ForEach(Console.WriteLine);
    }
/*
    static string NameUpper(Product p)
    {
        return p.Name.ToUpper();
    }
*/
}