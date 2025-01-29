using System;
using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.ValorASerPago(dolares).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}