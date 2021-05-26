using System;

/// <summary> Class for VectorMath. </summary>
class VectorMath
{
    /// <summary> Calculates and returns the length of a given vector. </summary>
    public static double Magnitude(double[] vector){
        if (vector.Length == 1 || vector.Length > 3)
            return -1;
        double sum = 0f;
        foreach (var number in vector)
        {
            sum += Math.Pow(number,2);
        }
        return Math.Round(Math.Sqrt(sum),2);
    }
}