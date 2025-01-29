using System;
using System.Globalization;

namespace Vetores
{
    public class Program
    {
        static void Main(string[] args)
        {
            exercicio1();
            exercicio2();
        }

        private static void exercicio1()
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            Console.WriteLine($"AVERAGE HEIGHT = {(soma / n).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void exercicio2() {

            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product
                {
                    Name = name,
                    Price = price
                };
            }

            double sum = 0;

            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
