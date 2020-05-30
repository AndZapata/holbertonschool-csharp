using System;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Function to multiply a vector by a scalar
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="scalar"></param>
    /// <returns>a new vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] fail = new double[1] { -1 };
        if (vector.Length == 2 || vector.Length == 3)
        {
            double[] result = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
                result[i] = vector[i] * scalar;
            return result;
        }
        return (fail);
    }
}
