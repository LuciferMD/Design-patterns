using System;
using static Laba1.MethodJordanGaussa;
using static Laba1.MethodGaussa;
using System.Collections.Generic;


namespace Laba1
{

    public class Program
    {
        public static void Main(String[] args)
        {
            float[,] a = {{ 0, 2, 1, 4 },
                  { 1, 1, 2, 6 },
                  { 2, 1, 1, 7 }};



            MethodJordanGaussa.PrintExtendedMatrix(a);

            int resultCode = SolvingSystemLEMethodJG(a);

            // Printing Final Matrix
            Console.WriteLine();
            Console.WriteLine("     Final Matrix is : ");
            MethodJordanGaussa.PrintExtendedMatrix(a);
            Console.WriteLine("");

            // Printing Solutions(if exist)
            PrintResult(a, resultCode);

            Console.WriteLine();
            gaussianElimination(a);
        }
    }
}


