using System;

class MatrixMath
{
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] empty = new double[,] { { } };
        double[,] result;
        if (matrix.GetLength(0) == 0)
            return empty;
        result = new double[matrix.GetLength(0),matrix.GetLength(1)];
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                result[i, j] = matrix[j, i];
        
        return result;
    }
}
