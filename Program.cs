using System;
using System.Collections;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
			{
		

			double[][] sle =   {
			 	new double[] { 10,6,2,0},
				new double[] { 5,1,-2,4},
				new double[] { 3,5,1,-1},
				new double[]{ 0,6,-2,2}
			
					};
            // double[][] freeMembers = { new double[] { 25, 14, 10, 8 } };

            double[][] freeMembers =   {
                new double[] {25},
                new double[] {14},
                new double[] {10},
                new double[]{ 8}
                    };

            double[] X =  { 1, 1, 1, 1 } ;

            
			GaussMethod gaussMethod = new GaussMethod();

			gaussMethod.GaussMethodChoice(sle, freeMembers, X);

		
            



		}
    }
}
