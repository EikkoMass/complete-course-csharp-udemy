using ExercicioPropostoHeranPoli.Entidades;
using System.Globalization;

namespace ExercicioPropostoHeranPoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                
                Console.Write("Common, used or imported (c/u/i)? ");
                string type = Console.ReadLine();
                
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if(name == null)
                {
                    name = "";
                }

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (type) {
                    case "i":

                        Console.Write("Custom Fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
                        products.Add(new ImportedProduct(name, price, fee));
                        break;

                    case "u":

                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        DateOnly manufactureDate = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    default:
                        products.Add(new Product(name, price));
                        break;

                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            
            foreach (Product product in products) { 
                Console.WriteLine(product.PriceTag()); 
            }

        }
    }
}
