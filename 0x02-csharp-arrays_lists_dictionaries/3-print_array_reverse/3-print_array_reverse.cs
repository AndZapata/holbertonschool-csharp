﻿using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int i;
        if (array == null || array.Length == 0)
	{
	    Console.Write("\n");
	    return;
        }
        for (i = array.Length - 1; i >= 0; i--)
	{
	    if (i != 0)
	        Console.Write("{0} ", array[i]);
	    else
	        Console.Write("{0}\n", array[i]);
        }
    }
}
