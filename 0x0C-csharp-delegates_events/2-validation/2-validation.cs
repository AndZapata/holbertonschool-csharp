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
        if (maxHp <= 0f)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.name = name;
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Method to print default values
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// Function to check the damage taken
    /// </summary>
    /// <param name="damage"> how many damage the player takes</param>
    public void TakeDamage(float damage)
    {
        float status = this.hp;
        if (damage < 0f)
            damage = 0f;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        status -= damage;
        this.ValidateHP(status);
    }

    /// <summary>
    /// Function to check heal taken
    /// </summary>
    /// <param name="heal">How many heal the player takes</param>
    public void HealDamage(float heal)
    {
        float status = this.hp;
        if (heal < 0f)
            heal = 0f;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        status += heal;
        this.ValidateHP(status);
    }

    /// <summary>
    /// Function to validate the healt of the player
    /// </summary>
    /// <param name="newHp"> The value to be checked </param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
}

/// <summary>
/// delegate CalculateHealth that takes a float amount
/// </summary>
/// <param name="amount">float amount to be taken</param>
public delegate void CalculateHealth(float amount);
