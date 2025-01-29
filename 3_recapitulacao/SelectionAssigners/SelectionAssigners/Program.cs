using System;

namespace SelectionAssigners
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            int a2 = 10;
            a2++;
            Console.WriteLine(a2);

            a2--;
            Console.WriteLine(a2);

            Console.WriteLine(a2++);
            Console.WriteLine(a2);

            Console.WriteLine(++a2);
            Console.WriteLine(a2);

        }
    }
}