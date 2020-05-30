using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function to check the transpose of a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>a new matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] empty = new double[,] { { } };
        double[,] result;
        if (matrix.GetLength(0) == 0)
            return empty;
        result = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(1); i++)
            for (int j = 0; j < matrix.GetLength(0); j++)
                result[i, j] = matrix[j, i];
        
        return result;
    }
}
