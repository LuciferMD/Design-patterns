using System;
using System.Collections.Generic;
using System.Text;


namespace Laba1
{
    class GaussMethod
    {
		void swap_rows(double[][] sle,int first, int second)
        {
			int rows = sle.Length;
			double[] temp_raw = new double[rows];

			for (int j = 0; j < rows; j++)
			{
				temp_raw[j] = sle[first][j];
			}
			for (int j = 0; j < rows; j++)
			{
				sle[first][j] = sle[second][j];
			}
			for (int j = 0; j < rows; j++)
			{
				sle[second][j] = temp_raw[j];
			}
		}

		int find_max_of_selected_column(double[][] sle, int _j, int i_top)
        {
			double max;
			int i_max;
			int rows = sle.Length;     // количество строк
			int columns = sle[0].Length;         // количество столбцов

			max = Math.Abs(sle[i_top][_j]);
			i_max = i_top;

			for (int i = i_top; i < columns; i++)
			{
				if (Math.Abs(sle[i][_j]) > max)
				{
					max = sle[i][_j];
					i_max = i;
				}
			}
			return i_max;
		}

		double advanced_summ_of_row(double[][] sle,double[] X, int _i)
        {
			double summ = 0;
			int rows = sle.Length; // количество строк

			for (int j = _i + 1; j < rows; j++)
			{
				summ = summ + sle[_i][j] * X[j];
			}
			return summ;
		}

		public void GaussMethodChoice(double[][] sle, double[][] freeMembers,  double[] X) //system liner , free member and X=x1 x2 ...
        {

			int rows = sle.Length;    // количество строк
			int columns = sle[0].Length;        // количество столбцов

			for (int k = 0; k < columns - 1; k++)
			{
				int index_max = find_max_of_selected_column(sle, k, k);
				swap_rows(sle, index_max, k);
				swap_rows(freeMembers, index_max, k);
				for (int i = k + 1; i < columns; i++)
				{
					double mu = sle[i][k] / sle[k][k];
					for (int j = 0; j < rows; j++)
					{
						sle[i][j] = sle[i][j] - mu * sle[k][j];
					}
					freeMembers[i][0] = freeMembers[i][0] - mu * freeMembers[k][0];
				}

			}
			//*********direct order********
			//*********reverse order********
			X[columns - 1] = freeMembers[columns - 1][0] / sle[columns - 1][rows - 1];
			for (int i = columns - 2; i >= 0; i--)
			{
				double summ = advanced_summ_of_row(sle, X, i);
				X[i] = (freeMembers[i][0] - summ) / sle[i][i];
			}
			//*********reverse order********
		}

	}
}
