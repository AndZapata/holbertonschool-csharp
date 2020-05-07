using System;

/// <summary>
/// Class obj
/// </summary>
class Obj
{
    /// <summary>
    /// Function to check if an object is an int
    /// </summary>
    /// <param name="obj">the object to be checked</param>
    /// <returns>true if is an int, otherwise false</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
