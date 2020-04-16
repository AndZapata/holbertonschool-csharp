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
        for (i = 0; i < size; i++)
	{
            index[i] = i;
        }
        return (index);
    }
}
