using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
	/// <summary> Multiplies two matrices and returns the resulting matrix. </summary>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)], error = { { -1 } };
		double total;

		if (matrix1.GetLength(1) == matrix2.GetLength(0))
		{
			for (int i = 0; i < matrix1.GetLength(0); i++)
			{
				for (int j = 0; j < matrix2.GetLength(1); j++)
				{
					total = 0;
					for (int k = 0; k < matrix1.GetLength(1); k++)
					{
						total += (matrix2[k, j]) * (matrix1[i, k]);
					}
					result[i, j] = total;
				}
			}
			return (result);
		}
		else
			return (error);
	}
}