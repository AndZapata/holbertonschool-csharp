using System;

namespace MyMath {
    /// <summary>
    /// Class Matrix
    /// </summary>
    public class Matrix {
        /// <summary>
        /// Function to divide each int in a matrix by a given int
        /// </summary>
        /// <param name="matrix">The multidimetional array of integers</param>
        /// <param name="num">The integer which divide each int in the matrix</param>
        /// <returns>New matrix with the result of divs</returns>
        public static int[, ] Divide (int[, ] matrix, int num) {
            if (matrix == null)
                return null;
            try {
                for (int i = 0; i < matrix.GetLength (0); i++) {
                    for (int j = 0; j < matrix.GetLength (1); j++) {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return matrix;
            } catch (DivideByZeroException) {
                Console.WriteLine ("Num cannot be 0");
                return null;
            }
        }
    }
}
