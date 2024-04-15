using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            /*
            if(x == 1)
            {
                day = "Sunday";
            } else if (x == 2)
            {
                day = "Monday";
            } else if (x == 3) {
                day = "Tuesday";
            } else if (x == 4)
            {
                day = "Wednesday";
            } else if (x == 5)
            {
                day = "Thursday";
            } else if (x == 6) {
                day = "Friday";
            } else if (x == 7)
            {
                day = "Saturday";
            } else
            {
                day = "Invalid value";
            }
            */

            switch(x)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid Date";
                    break;
            }

            Console.WriteLine($"Day: {day}");
        }
    }
}
