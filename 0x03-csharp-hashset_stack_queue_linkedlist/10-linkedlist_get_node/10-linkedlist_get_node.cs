using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n > myLList.Count)
            return 0;
        int idx = 0;
        foreach (int i in myLList)
        {
            if (idx == n)
                return i;
            idx += 1;
        }
        return 0;
    }
}
