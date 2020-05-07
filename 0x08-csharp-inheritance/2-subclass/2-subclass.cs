using System;

/// <summary>
/// Class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// Function to check if a subclass of a base class
    /// </summary>
    /// <param name="derivedType">Object to be checked</param>
    /// <param name="baseType">Object to compare</param>
    /// <returns>true if is a subclass, false if not</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
