using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int len = aQueue.Count;
        bool check = aQueue.Contains(search);
        Console.WriteLine("Number of items: {0}", len);
        if (len > 0)
            Console.WriteLine("First item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Queue is empty");
        aQueue.Enqueue(newItem);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, check);
        if (check)
            while(aQueue.Dequeue() != search);
        return aQueue;
    }
}
