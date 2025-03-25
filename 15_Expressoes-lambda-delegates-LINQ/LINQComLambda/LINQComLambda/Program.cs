using LINQComLambda.Entities;

namespace LINQComLambda;

public class Program
{
    
    static void Print<T>(string message, IEnumerable<T> items)
    {
        Console.WriteLine(message);
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
        Category c3 = new Category { Id = 3, Name = "Electronics", Tier = 1 };

        List<Product> products = new List<Product>
        {
            new() { Id = 1, Name = "Computer", Price = 1100.00, Category = c2 },
            new() { Id = 2, Name = "Hammer", Price = 90.00, Category = c1 },
            new() { Id = 3, Name = "TV", Price = 1700.00, Category = c3 },
            new() { Id = 4, Name = "Notebook", Price = 1300.00, Category = c2 },
            new() { Id = 5, Name = "Saw", Price = 80.00, Category = c1 },
            new() { Id = 6, Name = "Tablet", Price = 700.00, Category = c2 },
            new() { Id = 7, Name = "Camera", Price = 700.00, Category = c3 },
            new() { Id = 8, Name = "Printer", Price = 350.00, Category = c3 },
            new() { Id = 9, Name = "MacBook", Price = 1800.00, Category = c2 },
            new() { Id = 10, Name = "Sound Bar", Price = 700.00, Category = c3 },
            new() { Id = 11, Name = "Level", Price = 70.00, Category = c1 },
        };

        Print("TIER 1 AND PRICE < 900", products.Where(p => p.Category.Tier == 1 && p.Price < 900.00));
        Print("NAME OF PRODUCTS FROM TOOLS", products.Where(p => p.Category.Name == "Tools").Select(p => p.Name));
        Print("PRODUCTS STARTED WITH 'C' AND ANONYMOUS OBJECT", products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name}));
        Print("TIER 1 ORDER BY PRICE THEN BY NAME", products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name));
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name).Skip(2).Take(4));
        Console.WriteLine("First or Default test1: " + products.FirstOrDefault());
        Console.WriteLine("First or Default test2: " + products.Where(p => p.Price > 3000).FirstOrDefault());
        Console.WriteLine("Single or Default test1: " + products.Where(p => p.Id == 3).SingleOrDefault());
        Console.WriteLine("Single or Default test2: " + products.Where(p => p.Id == 30).SingleOrDefault());

    }
}