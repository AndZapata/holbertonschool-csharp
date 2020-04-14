using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
	int number = rndm.Next(-10000, 10000);
        int mod = 0;
	string str = "The last digit of ";
        if (number < 0)
	{
	    mod = ((-1 * number) % 10) * -1;
        }
	else
	{
	    mod = number % 10;
        }
	if (mod == 0)
	{
	    Console.WriteLine("{0}{1} is {2} and is 0", str, number, mod);
        }
	else if (mod > 5)
	{
	    Console.WriteLine("{0}{1} is {2} and is greater than 5", str, number, mod);
        }
	else if (mod < 6)
	{
	    Console.WriteLine("{0}{1} is {2} and is less than 6 and not 0", str, number, mod);
        }
    }
}
