using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> unique = myList.Distinct().ToList();
        int total = unique.Sum(item => item);
        return total;
    }
}
