using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            CreateMatrix(matrix, n);

            int sum = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        continue;
                    }

                    sum++;
                    matrix[i, j] = sum;
                }

                for (int k = i; k < n; k++)
                {
                    if (matrix[k, n - i - 1] != 0)
                    {
                        continue;
                    }

                    sum++;
                    matrix[k, n - i - 1] = sum;
                }



                for (int o = n - 1; o >= 0; o--)
                {
                    if (matrix[n - i - 1,  o] != 0)
                    {
                        continue;
                    }

                    sum++;
                    matrix[n - i - 1, o] = sum;
                }

                for (int l = n - 1; l > i; l--)
                {
                    if (matrix[l - i - 1, i] != 0)
                    {
                        continue;
                    }

                    sum++;
                    matrix[l - i - 1, i] = sum;
                }
            }

            PrintMatrix(matrix, n);
        }

        private static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        private static void CreateMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
    }
}
