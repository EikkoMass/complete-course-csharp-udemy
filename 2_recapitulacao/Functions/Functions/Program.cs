using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maior = {Maior(n1, n2, n3)}");
        }

        private static int Maior(int a, int b, int c) {

            int m;

            if(a > b && a > c)
            {
                m = a;
            }
            else if(b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }
    }
}