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

/// <summary>
/// class Decoration: inherits from Base, IInteractive, IBreakable
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// check quest item existence
    /// </summary>
    public bool isQuestItem;
    /// <summary>
    /// check for the status of an item
    /// </summary>
    /// <value></value>
    public int durability {get; set;}
    /// <summary>
    /// Constructor to set the vars name, durability, and isQuestItem
    /// </summary>
    /// <param name="n">name</param>
    /// <param name="d">durability</param>
    /// <param name="iQI">isQuestItem</param>
    public Decoration(string n = "Decoration", int d = 1, bool iQI = false)
    {
        if (d <= 0)
            throw new Exception("Durability must be greater than 0");
        name = n;
        durability = d;
        isQuestItem = iQI;
    }
    /// <summary>
    /// interact with an object
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The {0} has been broken.", name);
        else if (isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    }

    /// <summary>
    /// check if the object has been broken
    /// </summary>
    public void Break()
    {
        durability -= 1;
        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        if (durability < 0)
            Console.WriteLine("The {0} is already broken.", name);
    }
}