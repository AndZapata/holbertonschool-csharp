using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        Console.WriteLine("{0}", aStack.Count > 0 ? "Top item: " + aStack.Peek : "Stack is empty");
        Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search) ? "True" : "False");
        while (aStack.Pop() != search);
        aStack.Push(newItem);
        
        return aStack;
    }
}
