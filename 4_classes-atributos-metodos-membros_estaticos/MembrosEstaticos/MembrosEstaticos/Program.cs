using System;
using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferencia: " + Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }

    }
}