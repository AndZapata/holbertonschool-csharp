using System;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Function that returns the magnitude of a vector
    /// </summary>
    /// <param name="vector"></param>
    /// <returns>a double single number</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            double result = 0;
            for (int i = 0; i < vector.Length; i++)
                result = result + (vector[i] * vector[i]);
            return (Math.Round(Math.Sqrt(result), 2));
        }
        return (-1);
    }
}
