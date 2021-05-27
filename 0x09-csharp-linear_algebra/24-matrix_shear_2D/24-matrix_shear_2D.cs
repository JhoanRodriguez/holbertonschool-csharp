using System;

/// <summary> Class for MatrixMath. </summary>
class MatrixMath
{
	/// <summary> Shears a square 2D matrix by a given shear factor and returns the resulting matrix. </summary>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		double[,] error = { { -1 } }, result = new double[2, 2], shear;

		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			if (direction == 'x')
				shear = new double[,] { { 1, 0 }, { factor, 1 } };
			else if (direction == 'y')
				shear = new double[,] { { 1, factor }, { 0, 1 } };
			else
				return (error);

			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					for (int k = 0; k < 2; k++)
					{
						result[i, j] += matrix[i, k] * shear[k, j];
					}
				}
			}
			return (result);
		}
		else
			return (error);
	}
}