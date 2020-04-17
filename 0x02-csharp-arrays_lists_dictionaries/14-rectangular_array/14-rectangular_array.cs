using System;

class Program
{
    static void Main(string[] args)
    {
        int i, j, num = 0;
	for (i = 0; i < 5; i++)
	{
	    for (j = 0; j < 5; j++)
	    {
	        if (j == 2 && i == 2)
		    Console.Write(num + 1);
		else
	            Console.Write(num);
            }
	    Console.WriteLine();
        }
    }
}
