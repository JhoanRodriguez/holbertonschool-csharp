using System;

/// <summary> Class for VectorMath. </summary>
class VectorMath
{
	/// <summary> Calculates the cross product of two 3D vectors and returns the resulting vector. </summary>
	public static double[] CrossProduct(double[] vector1, double[] vector2)
	{
		double[] answer = new double[3];

		if (vector1.Length == 3 && vector2.Length == 3)
		{
			answer[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
			answer[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
			answer[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
			return (answer);
		}
		else
			return (new double[] { -1 });
	}
}