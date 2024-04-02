using System;

namespace Conditinals
{
    class Program
    {
        public static void Main(string[] args)
        {
            Example1();
            Example2();
            Example3();
        }

        private static void Example1()
        {
            int x = 10;

            Console.WriteLine("Bom Dia");

            if (x > 5)
            {
                Console.WriteLine("Boa Tarde");
            }

            Console.WriteLine("Boa Noite");
        }

        private static void Example2()
        {
            Console.WriteLine("Entre com um número inteiro");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }

        private static void Example3()
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            
            if(hora < 12)
            {
                Console.WriteLine("Bom Dia!");
            } else if (hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}