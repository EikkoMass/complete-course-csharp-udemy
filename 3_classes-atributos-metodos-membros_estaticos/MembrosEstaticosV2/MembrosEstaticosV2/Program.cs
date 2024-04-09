using System;
using System.Globalization;

namespace MembrosEstaticosV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double .Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferência: " + Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferência: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}