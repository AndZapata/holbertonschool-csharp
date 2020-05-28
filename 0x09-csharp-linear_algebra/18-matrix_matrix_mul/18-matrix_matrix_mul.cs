using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] fail = new double[,] { { -1 } };
        if (matrix1.GetLength(0) != matrix2.GetLength(1))
            return fail;
        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        double operations = 0;
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
