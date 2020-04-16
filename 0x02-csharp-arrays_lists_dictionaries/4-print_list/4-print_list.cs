using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int i;
        if (size < 0)
	{
	    Console.WriteLine("Size cannot be negative");
	    return null;
        }
	List<int> newList = new List<int>();
	if (size == 0)
	{
	    Console.Write("\n");
	    return newList;
        }
	for (i = 0; i < size; i++)
	{
	    newList.Add(i);
	    if (i < size - 1)
	        Console.Write("{0} ", i);
	    else
	        Console.Write("{0}\n", i);
        }
        return newList;
    }
}
