using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FormatoDateTime
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /** First Contact */
            // TestePadrao();


            /** Constructors */
            // TesteConstrutores();


            /** Parsers */
            // TesteParse();

            /** Parse com mascara */
            // TesteParseComMascara();
        }

        private static void TestePadrao()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.Ticks);
        }
    
        private static void TesteConstrutores()
        {
            DateTime d1 = new DateTime(2018, 11, 25);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 300);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);
        }

        private static void TesteParse()
        {
            DateTime d1 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d1);

            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d2);

            DateTime d3 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d4);
        }

        private static void TesteParseComMascara()
        {
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);

            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d2);
        }
    }
}
