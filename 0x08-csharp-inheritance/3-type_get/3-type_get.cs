using System;
using System.Reflection;

/// <summary>
/// Class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// Function to print the info inside a typeinfo object
    /// </summary>
    /// <param name="myObj">Object to print his info</param>
    public static void Print(object myObj)
    {
        TypeInfo tInfo = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", tInfo.Name);
        foreach (PropertyInfo prop in tInfo.GetProperties())
            Console.WriteLine("{0}", prop.Name);
        Console.WriteLine("{0} Methods:", tInfo.Name);
        foreach (MethodInfo meth in tInfo.GetMethods())
            Console.WriteLine("{0}", meth.Name);
    }
}
