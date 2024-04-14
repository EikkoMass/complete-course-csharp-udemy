using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioResolvidoMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main Diagonal");
            for(int i=0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            int negatives = 0;

            for (int i =0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    if (mat[i,j] < 0) negatives++;
                }
            }

            Console.WriteLine("Negative Numbers: " + negatives);
        }


    }
}
