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
		    Console.Write("{0} ", num + 1);
		else if (j < 4)
	            Console.Write("{0} ", num);
		else
		    Console.Write("{0}\n", num);
            }
        }
    }
}
