using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int mod;
	if (number > 0)
	{
	    mod = number % 10;
        }
	else
	{
	    mod = ((-1 * number) % 10);
        }
	Console.Write(mod);
	return (mod);
    }
}
