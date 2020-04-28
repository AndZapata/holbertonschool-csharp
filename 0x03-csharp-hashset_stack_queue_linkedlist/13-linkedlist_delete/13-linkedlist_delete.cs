using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> current = myLList.First;
        while (i <= index && current.Next != null)
        {
            if (i == index)
                myLList.Remove(current);
            current = current.Next;
            i += 1;
        }
        if (i == index)
            myLList.Remove(current);
    }
}
