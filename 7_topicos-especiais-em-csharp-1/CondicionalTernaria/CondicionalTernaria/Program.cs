using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalTernaria
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            /*
                if(preco < 20.0)
                {
                    desconto = preco * 0.1;
                } else
                {
                    desconto = preco * 0.05;
                }
            */

            desconto = preco * (preco < 20.0 ? 0.1 : 0.05); 

            Console.WriteLine(desconto);
        }
    }
}
