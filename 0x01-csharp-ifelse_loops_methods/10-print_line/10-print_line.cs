using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
	{
	    Console.Write("\n");
        }
	else
	{
	    string ch = new String('_', length);
	    Console.WriteLine(ch);
        }
    }
}
