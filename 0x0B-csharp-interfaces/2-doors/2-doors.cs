using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Abstract class Base
/// </summary>
public abstract class Base
{
  /// <summary>
  /// given name of the object
  /// </summary>
  public string name;

  /// <summary>
  /// Function ToString override
  /// </summary>
  /// <returns> returns a new string with name and its type</returns>
  public override string ToString() => $"{name} is a {this.GetType()}";
}

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Class Door that inherits from base and Iinteractive
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Door constructor to set the name variable
    /// </summary>
    /// <param name="n">param to set the name var</param>
    public Door(string n = "Door")
    {
        name = n;
    }
    /// <summary>
    /// prints when interacts
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
    
}
