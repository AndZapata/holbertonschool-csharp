using System;

/// <summary>
/// matrix math class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// function to add two matrix
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>a new matrix</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] fail = new double[,] { { -1 } };
        if ((matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3) || (matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3))
            return fail;
        else if ((matrix1.GetLength(1) != matrix1.GetLength(0)) || (matrix2.GetLength(1) != matrix2.GetLength(0)))
            return (fail);
        else
        {
            double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
                for (int j = 0; j < matrix1.GetLength(1); j++)
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
            return result;
        }
    }
}
