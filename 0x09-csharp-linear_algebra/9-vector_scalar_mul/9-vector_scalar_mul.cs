using System;

/// <summary> Class for VectorMath. </summary>
class VectorMath
{
	/// <summary> Multiplies a vector and a scalar and returns the resulting vector. </summary>
	public static double[] Multiply(double[] vector, double scalar)
	{
		if (vector.Length == 2)
		{
			double[] answer = { 0, 0 };
			answer[0] = vector[0] * scalar;
			answer[1] = vector[1] * scalar;
			return (answer);
		}
		else if (vector.Length == 3)
		{
			double[] answer = { 0, 0, 0 };
			answer[0] = vector[0] * scalar;
			answer[1] = vector[1] * scalar;
			answer[2] = vector[2] * scalar;
			return (answer);
		}
		else
		{
			return (new double[] { -1 });
		}
	}
}