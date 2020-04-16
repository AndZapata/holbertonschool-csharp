using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int i;
	int[] index;
	if (size < 0)
	{
	    Console.WriteLine("Size cannot be negative");
            return (null);
        }
	index = new int[size];
        if (size == 0)
	    return index;
        for (i = 0; i < size; i++)
	{
            index[i] = i;
	    if (i < size - 1)
	        Console.Write("{0} ", i);
	    else
	        Console.Write("{0}\n", i);
        }
        return (index);
    }
}
