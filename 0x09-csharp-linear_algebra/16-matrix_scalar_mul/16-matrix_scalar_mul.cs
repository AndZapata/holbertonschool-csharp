using System;

/// <summary>
/// Matrix Math class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// function to multiply a matrix by a scalar
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="scalar"></param>
    /// <returns>a new matrix</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] fail = new double[,] { { -1 } };
        if (matrix.GetLength(0) == 2 || matrix.GetLength(0) == 3)
        {
            if (matrix.GetLength(1) == matrix.GetLength(0))
            {
                double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        result[i, j] = matrix[i, j] * scalar;
                return result;
            }
        }
        return (fail);
    }
}
