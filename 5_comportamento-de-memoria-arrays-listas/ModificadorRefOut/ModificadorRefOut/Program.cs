using System;

namespace ModificadorRefOut
{
    class Program
    {
       static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int tripleB;
            Calculator.Triple(b, out tripleB);
            Console.WriteLine(tripleB);
        }
    }
}