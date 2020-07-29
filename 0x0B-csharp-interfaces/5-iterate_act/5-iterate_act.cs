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
    /// <param name="name">param to set the name var</param>
    public Door(string name = "Door")
    {
        this.name = name;
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
    /// <param name="name">name</param>
    /// <param name="durability">durability</param>
    /// <param name="isQuestItem">isQuestItem</param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
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

/// <summary>
/// class Key inherits: Base, ICollectable
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// property instanciate
    /// </summary>
    /// <value></value>
    public bool isCollected {get; set;}
    /// <summary>
    /// Constructor to set isCollected, name
    /// </summary>
    /// <param name="name"></param>
    /// <param name="isCollected"></param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Function to check if the keys are collected
    /// </summary>
    public void Collect()
    {
        if (!isCollected)
        {
            isCollected = true;
            Console.WriteLine("You pick up the {0}.", name);
        }
        else
            Console.WriteLine("You have already picked up the {0}.", name);
    }
}

/// <summary>
/// Public class RoomObjects
/// </summary>
public class RoomObjects
{
    /// <summary>
    /// Function to check a list of items in a room a proceed acording to its type
    /// </summary>
    /// <param name="roomObjects"> the list of items </param>
    /// <param name="type"> the type of the elements </param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (type.IsInstanceOfType(item))
            {
                if (type == typeof(IInteractive))
                    ((IInteractive)item).Interact();
                if (type == typeof(IBreakable))
                    ((IBreakable)item).Break();
                if (type == typeof(ICollectable))
                    ((ICollectable)item).Collect();
            }
        }
    }
}
