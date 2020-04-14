using System;

class Program
{
    static void Main(string[] args)
    {
        char letter;
	for (letter = 'a'; letter <= 'z'; letter++)
	{
	    if (letter != 'e' && letter != 'q')
	    {
	        Console.Write(letter);
            }
        }
    }
}
