using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> link = new LinkedList<int>();

        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                link.AddFirst(i);
                Console.WriteLine(i);
            }
        }

        return link;
    }
}
