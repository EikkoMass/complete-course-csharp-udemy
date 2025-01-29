using System;

namespace ImplicitAndCasting
{
    class Program
    {
        public static void Main(string[] args)
        {
            double a;
            float b;
            int c;

            a = 5.1;
            b = (float) a;
            c = (int) a;

            Console.WriteLine(b);
            Console.WriteLine(c);

            int d = 5;
            int e = 2;

            double resultado = (double) d / e;

            Console.WriteLine(resultado);
        }
    }
}