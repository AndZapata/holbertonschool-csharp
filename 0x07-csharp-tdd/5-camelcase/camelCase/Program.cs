using System;
using Text;

class Program
{
    static void Main(string[] args)
    {
        string s = "asdfds";
        int result = Text.Str.CamelCase(s);

        Console.WriteLine(result);
    }
}
