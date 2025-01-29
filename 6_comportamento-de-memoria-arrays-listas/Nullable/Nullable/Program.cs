using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            // Nullable<double> x = null;

            double? y = 10.0;
            
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if(y.HasValue)
            {
                Console.WriteLine(y.Value);
            } else
            {
                Console.WriteLine("Y is null");
            }


            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
