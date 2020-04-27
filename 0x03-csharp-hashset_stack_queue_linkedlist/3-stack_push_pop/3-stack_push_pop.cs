﻿using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool flag = aStack.Contains(search);
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count > 0)
            Console.WriteLine("Top item: {0}", aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
        Console.WriteLine("Stack contains {0}: {1}", search, flag);
        if (flag)
            while (aStack.Pop() != search)
            {}        
        aStack.Push(newItem);
        
        return aStack;
    }
}
