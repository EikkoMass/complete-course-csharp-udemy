using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InferenciaTiposVar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            var w = z;
            // int  = z;

            Console.WriteLine(x);
            Console.WriteLine(y); 
            Console.WriteLine(z);
        }
    }
}
