using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] fail = new double[,] { { -1 } };
        double[,] matrix2 = new double[,] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double operations;
        double[,] result = new double[2, 2];
        
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return fail;
        
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                operations = 0;
                for (int k = 0; k < 2; k++)
                    operations = operations + Math.Round((matrix[i, k] * matrix2[k, j]), 2);
                result[i, j] = operations;
            }
        
        return result;
    }
}
