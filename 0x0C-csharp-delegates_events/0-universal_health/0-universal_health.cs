using System;

/// <summary>
/// Class Player
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player constructor to set values
    /// </summary>
    /// <param name="name">Name of the player</param>
    /// <param name="maxHp">The maximum of health</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;
        this.hp = this.maxHp;
        this.name = name;
    }

    /// <summary>
    /// Method to print default values
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
