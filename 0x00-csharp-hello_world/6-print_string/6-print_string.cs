using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
	for (int i = 0; i < 4; i++)
	{
	    if (i < 3)
	    {
                Console.Write("{0}", str);
            }
	    else if (i == 3)
	    {
	        Console.Write("\n{0}\n", str.Substring(0, 9));
            }
        }
    }
}
