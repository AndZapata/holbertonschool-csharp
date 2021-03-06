﻿using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// function that returns the Determinant of a matrix 
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>double single number</returns>
    public static double Determinant(double[,] matrix)
    {
        double result = 0;
        if ((matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3) || (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2))
        {
            if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
                result = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
            else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
                result = Math.Round((matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))) - (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))) + (matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]))), 2);
            return result;
        }
        return -1;
    }
}
