using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatoTimeSpan
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            /** Getting into */
            // TestePadrao();

            /** Constructors */
            // TesteConstructors();

            /** Utils */
            // TesteMetodos();
        }

        private static void TestePadrao()
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
        }

        private static void TesteConstructors()
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);  
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
        }

        private static void TesteMetodos()
        {
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
        }
    }
}
