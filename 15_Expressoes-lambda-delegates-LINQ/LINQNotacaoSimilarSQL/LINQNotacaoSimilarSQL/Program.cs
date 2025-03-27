using LINQNotacaoSimilarSQL.Entities;

namespace LINQNotacaoSimilarSQL;

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

        Print("TIER 1 AND PRICE < 900", from p in products where p.Category.Tier == 1 && p.Price < 900.00 select p);
        Print("NAME OF PRODUCTS FROM TOOLS", from p in products where p.Category.Name == "Tools" select p.Name);
        Print("PRODUCTS STARTED WITH 'C' AND ANONYMOUS OBJECT",
            from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name });
        Print("TIER 1 ORDER BY PRICE THEN BY NAME",
            from p in products where p.Category.Tier == 1 orderby p.Name, p.Price select p);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4",
            (from p in products where p.Category.Tier == 1 orderby p.Price, p.Name select p).Skip(2).Take(4));
        Console.WriteLine("First or Default test1: " + (from p in products select p).FirstOrDefault());
        Console.WriteLine("First or Default test2: " +
                          (from p in products where p.Price > 3000 select p).FirstOrDefault());
        
        foreach (IGrouping<Category, Product> group in from p in products group p by p.Category)
        {
            Console.WriteLine($"Category {group.Key.Name}: ");
            foreach (Product product in group)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();
        }
    }
}