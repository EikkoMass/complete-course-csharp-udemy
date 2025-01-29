using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesDateTime
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /** Values */
            // TesteValores();

            /** Output */
            // TesteFormatacao();

            /** Operations */
            TesteOperacoes();


                       
        }

        private static void TesteValores()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2) Day: {d.Day}");
            Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"5) Hour {d.Hour}");
            Console.WriteLine($"6) Kind: {d.Kind}");
            Console.WriteLine($"7) Millisecond: {d.Millisecond}");
            Console.WriteLine($"8) Minute: {d.Minute}");
            Console.WriteLine($"9) Month: {d.Month}");
            Console.WriteLine($"10) Second: {d.Second}");
            Console.WriteLine($"11) Ticks: {d.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13) Year: {d.Year}");
        }

        private static void TesteFormatacao()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        }
        private static void TesteOperacoes()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2000, 10, 15);
            DateTime d5 = new DateTime(2000, 10, 18);

            TimeSpan t = d5.Subtract(d4);

            Console.WriteLine(t);
        }
    }
}
