using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        for (number = 0; number < 99; number++)
	{
	    Console.WriteLine("{0} = 0x{0:x}", number);
        }
    }
}
