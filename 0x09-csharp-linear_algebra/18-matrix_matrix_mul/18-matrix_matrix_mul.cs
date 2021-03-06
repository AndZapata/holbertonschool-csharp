﻿using System;

/// <summary>
/// Matrix Math class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// function to multiply two matrix
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>a new matrix</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] fail = new double[,] { { -1 } };
        double operations;
        double[,] result;
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return fail;
        else
            result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                operations = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                    operations = operations + (matrix1[i, k] * matrix2[k, j]);
                result[i, j] = operations;
            }
        return result;
    }
}
