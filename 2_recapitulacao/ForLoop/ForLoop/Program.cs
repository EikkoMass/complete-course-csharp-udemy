using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Valor #{i}: ");
                soma += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma: " + soma);
        }
    }
}