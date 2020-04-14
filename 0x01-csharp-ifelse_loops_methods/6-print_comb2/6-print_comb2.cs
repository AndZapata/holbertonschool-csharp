using System;

class Program
{
    static void Main(string[] args)
    {
        int i, j;
	for (i = 0; i <= 8; i++)
	{
	    for (j = 1; j <= 9; j++)
	    {
	        if (i < j)
		{
		    if (i == 8 && j == 9)
		    {
		        Console.Write("{0}{1}\n", i, j);
                    }
		    else
		    {
		        Console.Write("{0}{1}, ", i, j);
                    }
                }
            }
        }
    }
}
