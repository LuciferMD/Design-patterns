using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    public static class MehodGaussa 
    {
     
        // Function to get matrix content
        static void gaussianElimination(double[,] a)
        {
            int length = a.GetLength(0);
            /* reduction into r.e.f. */
            int singular_flag = forwardElim(a);

            /* if matrix is singular */
            if (singular_flag != -1)
            {
                Console.WriteLine("Singular Matrix.");

                /* if the RHS of equation corresponding to
                   zero row  is 0, * system has infinitely
                   many solutions, else inconsistent*/
                if (a[singular_flag, length] != 0)
                    Console.Write("Inconsistent System.");
                else
                    Console.Write("May have infinitely " +
                                  "many solutions.");

                return;
            }

            /* get solution to system and print it using
            backward substitution */
            backSub(a);
        }

        // Function for elementary operation of swapping two
        // rows
        static void swap_row(double[,] a, int i, int j)
        {
            int length = a.GetLength(0);
            // printf("Swapped rows %d and %d\n", i, j);

            for (int k = 0; k <= length; k++)
            {
                double temp = a[i, k];
                a[i, k] = a[j, k];
                a[j, k] = temp;
            }
        }

        // Function to print matrix content at any stage
        static void print(double[,] a)
        {
            int length = a.GetLength(0);
            for (int i = 0; i < length; i++, Console.WriteLine())
                for (int j = 0; j <= length; j++)
                    Console.Write(a[i, j]);

            Console.WriteLine();
        }

        // Function to reduce matrix to r.e.f.
        static int forwardElim(double[,] a)
        {
            int length = a.GetLength(0);
            for (int k = 0; k < length; k++)
            {

                // Initialize maximum value and index for pivot
                int i_max = k;
                int v_max = (int)a[i_max, k];

                /* find greater amplitude for pivot if any */
                for (int i = k + 1; i < length; i++)
                {
                    if (Math.Abs(a[i, k]) > v_max)
                    {
                        v_max = (int)a[i, k];
                        i_max = i;
                    }

                    /* If a prinicipal diagonal element  is zero,
                    *  it denotes that matrix is singular, and
                    *  will lead to a division-by-zero later. */
                    if (a[k, i_max] == 0)
                        return k; // Matrix is singular

                    /* Swap the greatest value row with 
                       current row
                    */
                    if (i_max != k)
                        swap_row(a, k, i_max);
                }
                    for (int i = k + 1; i < length; i++)
                    {

                        /* factor f to set current row kth element
                        *  to 0, and subsequently remaining kth
                        *  column to 0 */
                        double f = a[i, k] / a[k, k];

                        /* subtract fth multiple of corresponding
                           kth row element*/
                        for (int j = k + 1; j <= length; j++)
                            a[i, j] -= a[k, j] * f;

                        /* filling lower triangular matrix with
                        *  zeros*/
                        a[i, k] = 0;
                    }
                
                // print(mat);        //for matrix state
            }

            // print(mat);            //for matrix state
            return -1;
        }

        // Function to calculate the values of the unknowns
        static void backSub(double[,] a)
        {
            int length = a.GetLength(0);

            double[] x = new double[length];

            for (int i = length - 1; i >= 0; i--)
            {

                
                x[i] = a[i, length];

                /* Initialize j to i+1 since matrix is upper
                triangular*/
                for (int j = i + 1; j < length; j++)
                {

                    /* subtract all the lhs values
                     * except the coefficient of the variable
                     * whose value is being calculated */
                    x[i] -= a[i, j] * x[j];
                }

                /* divide the RHS by the coefficient of the
                unknown being calculated */
                x[i] = x[i] / a[i, i];
            }

            Console.WriteLine();
            Console.WriteLine("Solution for the system:");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0:F6}", x[i]);
                Console.WriteLine();
            }
        }
    }
}
