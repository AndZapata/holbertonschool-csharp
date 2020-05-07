using System;
using System.Reflection;

class Obj
{
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
