using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int i, j;
	if (length <= 0)
	    Console.Write("\n");
        else
	{
	    for (i = 0; i < length; i++)
	    {
	        for (j = 0; j < i; j++)
	        {
	            if (i > j && i < length)
		        Console.Write(" ");
                }
	        Console.Write("\\\n");
            }
	    Console.Write("\n");
        }
    }
}
