﻿using System;

/// <summary>
/// Vector math class
/// </summary>
class VectorMath
{
    /// <summary>
    /// function to find the dot product of two vector
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>a new vector</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double fail = -1;
        if ((vector1.Length == 2 || vector1.Length == 3) && (vector2.Length == 2 || vector2.Length == 3))
        {
            if (vector1.Length == vector2.Length)
            {
                double result = 0;
                for (int i = 0; i < vector1.Length && i < vector2.Length; i++)
                    result = result + (vector1[i] * vector2[i]);
                return result;
            }
        }
        return (fail);
    }
}
