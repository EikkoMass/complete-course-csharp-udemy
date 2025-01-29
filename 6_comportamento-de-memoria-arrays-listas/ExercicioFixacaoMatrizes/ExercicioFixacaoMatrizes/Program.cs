using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoMatrizes
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int[] coords = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

            int M = coords[0];
            int N = coords[1];

            int[,] map = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                for(int j = 0; j < N; j++)
                {
                    map[i, j] = line[j];
                }
            }

            int numberToFind = int.Parse(Console.ReadLine());

            for(int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (map[i,j] == numberToFind)
                    {
                        Console.WriteLine($"Position {i},{j}: ");


                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {map[i, j - 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {map[i - 1, j]}");
                        }

                        if (j < N - 1)
                        {
                            Console.WriteLine($"Right: {map[i, j + 1]}");
                        }

                        if (i < M - 1)
                        {
                            Console.WriteLine($"Down: {map[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
