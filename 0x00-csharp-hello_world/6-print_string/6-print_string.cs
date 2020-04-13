using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "Holberton School";
        string str2 = str + str + str;
	Console.WriteLine("{0}", str2);
	Console.WriteLine(str.Substring(0, 9));
    }
}
