using System;
using System.Collections.Generic;
using System.Text;
using static Laba1.MethodJordanGaussa;

namespace Laba1
{
    public class MatrixTools 
    {
        // Function for elementary operation of swapping two
        // rows
        public static void swap_row(float[,] a, int i, int j)
        {
            int length = a.GetLength(0);
            // printf("Swapped rows %d and %d\n", i, j);

            for (int k = 0; k <= length; k++)
            {
                float temp = a[i, k];
                a[i, k] = a[j, k];
                a[j, k] = temp;
            }
        }

        public static void PrintExtendedMatrix(float[,] a)
        {
            int length = a.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j <= length; j++)
                    Console.Write(a[i, j] + "\t");
                Console.WriteLine();
            }

        }
    }
}
