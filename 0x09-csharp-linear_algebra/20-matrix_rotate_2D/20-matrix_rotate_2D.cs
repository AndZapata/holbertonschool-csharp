using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] fail = new double[,] { { -1 } };
        double operations;
        double[,] result;
        double[,] matrix2 = new double[,] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return fail;
        else
            result = new double[matrix.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                operations = 0;
                for (int k = 0; k < matrix.GetLength(1); k++)
                    operations = operations + (matrix[i, k] * matrix2[k, j]);
                result[i, j] = Math.Round(operations, 0);
            }
        return result;
    }
}
