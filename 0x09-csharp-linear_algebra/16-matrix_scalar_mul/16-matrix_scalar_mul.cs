using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
	/// <summary> Multiplies a matrix and a scalar and returns the resulting matrix. </summary>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		double[,] empty_matrix = { { -1 } };

		if ((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) || (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3))
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = matrix[i, j] * scalar;
				}
			}
			return (matrix);
		}
		else
		{
			return (empty_matrix);
		}
	}
}