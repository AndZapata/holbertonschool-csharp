using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int i, j;
	for (i = 0; i < myMatrix.GetLength(0); i++)
	{
	    for (j = 0; j < myMatrix.GetLength(0); j++)
	    {
	        myMatrix[i, j] *= myMatrix[i, j];
            }
        }
	return myMatrix;
    }
}
