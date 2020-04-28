using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        if (current == null || myLList.First.Value >= newNode.Value)
        {
            myLList.AddLast(newNode);
            return newNode;
        }
        while (current.Next != null && current.Next.Value < newNode.Value)
            current = current.Next;
        myLList.AddAfter(current, newNode);
        return newNode;
    }
}
