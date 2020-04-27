using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> diff = new List<int>();
        foreach (int i in list1)
            if (!list2.Contains(i))
                diff.Add(i);

        foreach (int j in list2)
            if (!list1.Contains(j))
                diff.Add(j);

        diff.Sort();                
        return diff;
    }
}
