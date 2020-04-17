using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
	    return "None";
        List<string> newList = new List<string>();
        foreach (KeyValuePair<string, int> item in myList.OrderByDescending(key => key.Value))
	{
	    newList.Add(item.Key);
        }
        return newList[0];
    }
}
