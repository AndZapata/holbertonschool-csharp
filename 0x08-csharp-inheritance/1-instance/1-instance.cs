using System;

/// <summary>
/// Class Obj
/// </summary>
class Obj
{
    /// <summary>
    /// Function to check if an object is instance of array
    /// </summary>
    /// <param name="obj">The object to be checked</param>
    /// <returns>true if is an instance of array, false if not</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return typeof(Array).IsInstanceOfType(obj);
    }
}
