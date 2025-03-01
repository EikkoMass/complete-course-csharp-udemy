using GetHashCodeEquals.Entities;

namespace GetHashCodeEquals;

public class Program
{
    static void Main(string[] args)
    {
        Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
        Client b = new Client() { Name = "Alex", Email = "alex@gmail.com" };

        Console.WriteLine(a.Equals(b)); // comparando por E-mail (override)
        Console.WriteLine(a == b); // comparando referencia de memoria
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());
        Console.WriteLine(a.GetHashCode() == b.GetHashCode()); // Hashcode
    }
}