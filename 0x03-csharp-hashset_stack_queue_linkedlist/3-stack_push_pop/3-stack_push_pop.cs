using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack.Count > 0)
        {
            Console.WriteLine("Number of items: {0}\nTop item: {1}", aStack.Count, aStack.Peek());
            Console.WriteLine("Stack contains {0}: {1}", search, aStack.Contains(search) ? "True" : "False");
            while (aStack.Pop() != search);
            aStack.Push(newItem);
        }
        else
            Console.WriteLine("Stack is empty");


        return aStack;
    }
}
