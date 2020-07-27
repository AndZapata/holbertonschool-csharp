using System;

/// <summary>
/// Clase Queue Does not inherit from anything
/// </summary>
/// <typeparam name="T">param type</typeparam>
class Queue<T>
{
    /// <summary>
    /// Function to check the type of a param
    /// </summary>
    /// <returns>The type of the param</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
