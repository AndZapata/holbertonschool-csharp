using System;

/// <summary>
/// matrix class math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function to build the inverse of a 2D matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>new matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double det;
        double [,] fail = new double[,] { { -1 } };
        double [,] result = new double[2, 2];
        double [,] trans = new double[2, 2];
        
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return fail;
        trans[0, 0] = matrix[1, 1];
        trans[0, 1] = -1 * matrix[0, 1];
        trans[1, 0] = -1 * matrix[1, 0];
        trans[1, 1] = matrix[0, 0];
        det = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
        if (det == 0)
            return fail;
        double divDet = 1 / det;
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                result[i, j] = Math.Round(divDet * trans[i, j], 2);
        return result;
    }
}
