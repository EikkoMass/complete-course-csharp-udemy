using MetodoAbstratoResolvido.Entities;
using MetodoAbstratoResolvido.Entities.Enums;
using System.Globalization;

namespace MetodoAbstratoResolvido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color) Enum.Parse(typeof(Color), Console.ReadLine());

                if(shapeType == 'r' || shapeType == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Rectangle(width, height, color));
                } else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    shapes.Add(new Circle(radius, color));
                }

                Console.WriteLine();
            }

            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
