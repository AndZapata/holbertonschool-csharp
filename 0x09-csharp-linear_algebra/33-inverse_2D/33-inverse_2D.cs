using System;

class MatrixMath
{
    /// <summary>
    /// Function to build the inverse of a 2D matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>new matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double divDet = 1 / Determinant(matrix);
        double [,] fail = new double[,] { { -1 } };
        double [,] result = new double[2, 2];
        double [,] trasn = Transpose(matrix);
        
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return fail;
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                result[i, j] = Math.Round(divDet * trasn[i, j], 2);
        return result;
    }

    /// <summary>
    /// Function to obtain the determinant of a 2D matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>double type determinant</returns>
    public static double Determinant(double[,] matrix)
    {
        double result = 0;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            result = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
            return result;
        }
        return -1;
    }
    
    /// <summary>
    /// Function to transpose a matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>new matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] empty = new double[,] { { } };
        double[,] result;
        if (matrix.GetLength(0) == 0)
            return empty;
        result = new double[matrix.GetLength(1), matrix.GetLength(0)];
        result[0, 0] = matrix[1, 1];
        result[0, 1] = -1 * matrix[0, 1];
        result[1, 0] = -1 * matrix[1, 0];
        result[1, 1] = matrix[0, 0];
        
        return result;
    }
}
