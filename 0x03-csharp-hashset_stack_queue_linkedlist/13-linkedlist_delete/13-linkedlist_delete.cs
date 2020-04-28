using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList.Count > 0)
        {
            LinkedListNode<int> current = myLList.First;
            for (int i = 0; i <= index && current.Next != null; i++)
            {
                if (i == index)
                    myLList.Remove(current);
                current = current.Next;
            }
        }
    }
}
