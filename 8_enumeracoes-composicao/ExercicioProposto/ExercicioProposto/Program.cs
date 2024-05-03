using ExercicioProposto.Entities;
using ExercicioProposto.Entities.Enums;
using System.Globalization;

namespace ExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.WriteLine("Enter cliente data:");
            Console.Write("Nome: ");
            string Name = Console.ReadLine();

            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateOnly Birth = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Data:");

            order.Client = new Client(Name, Email, Birth);

            Console.Write("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order: ");
            int orderCount = int.Parse(Console.ReadLine());

            for(int i = 0; i < orderCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product Name: ");
                string ProductName = Console.ReadLine();

                Console.Write("Product Price: ");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

                Product Prod = new Product(ProductName, Price);
                order.AddItem(new OrderItem(Quantity, Prod.Price, Prod));
            }
            order.Moment = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order.ToString());

        }
    }
}
