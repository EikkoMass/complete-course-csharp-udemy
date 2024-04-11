using Encapsulamento;
using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        public static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}