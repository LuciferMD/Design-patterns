using System;
using System.Collections.Generic;
using System.Text;


namespace Laba1
{
    public  class MethodJordanGaussa : MatrixTools
    {
        public static int SolvingSystemLEMethodJG(float[,] matrix)
        {
            // Order of Matrix(n)
            int flag = 0;
            // Performing Matrix transformation
            flag = PerformOperation(matrix);

            if (flag == 1)
                flag = CheckConsistency(matrix, flag);

            return flag;
        }

        // Function to print the matrix
      

        // Function to print the desired result
        // if unique solutions exists, otherwise
        // prints no solution or infinite solutions
        // depending upon the input given.
        public static void PrintResult(float[,] a, int flag)
        {
            int length = a.GetLength(0);
            Console.Write("Result is : ");

            if (flag == 2)
                Console.WriteLine("Infinite Solutions Exists");
            else if (flag == 3)
                Console.WriteLine("No Solution Exists");

            else
            {
                for (int i = 0; i < length; i++)
                    Console.Write(a[i, length] / a[i, i] + " ");
            }
        }

        // To check whether infinite solutions
        // exists or no solution exists
        public static int CheckConsistency(float[,] a,  int flag)
        {
            int i, j;
            int length = a.GetLength(0);
            float sum;

            // flag == 2 for infinite solution
            // flag == 3 for No solution
            flag = 3;
            for (i = 0; i < length; i++)
            {
                sum = 0;
                for (j = 0; j < length; j++)
                    sum = sum + a[i, j];
                if (sum == a[i, j])
                    flag = 2;
            }
            return flag;
        }

        public static int PerformOperation(float[,] a)
        {
            int length = a.GetLength(0);
            int i, j, k = 0, c, flag = 0;

            // Performing elementary operations
            for (i = 0; i < length; i++)
            {
                if (a[i, i] == 0)
                {
                    c = 1;
                    while ((i + c) < length && a[i + c, i] == 0)
                        c++;
                    if ((i + c) == length)
                    {
                        flag = 1;
                        break;
                    }

                    swap_row(a, i, i + c);
                    
                } //Select max element in current row 
                for (int t = i, v = i; v < length; v++)
                {
                    if (a[t, t] < a[v, t])
                    {
                        swap_row(a, t, v);
                    }

                }
                for (j = 0; j < length; j++)
                {

                    // Excluding all i == j
                    if (i != j)
                    {

                        // Converting Matrix to reduced row
                        // echelon form(diagonal matrix)
                        float p = a[j, i] / a[i, i];

                        for (k = 0; k <= length; k++)
                            a[j, k] = a[j, k] - (a[i, k]) * p;
                    }
                }
            }
            return flag;
        }

    }


}
