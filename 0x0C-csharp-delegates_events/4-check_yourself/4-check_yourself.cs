using System;

/// <summary>
/// Class Player
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
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
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary>
    /// Function to apply a modifier to a baseValue
    /// </summary>
    /// <param name="baseValue">Value to be modified</param>
    /// <param name="modifier">Modifier</param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else
            return baseValue * 1.5f;
    }

    /// <summary>
    /// Check state
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            Console.WriteLine($"{this.name} is in perfect health!");
        else if (e.currentHp >= (this.maxHp * 0.5f) && e.currentHp < this.maxHp)
            Console.WriteLine($"{this.name} is doing well!");
        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp * 0.5f))
            Console.WriteLine($"{this.name} isn't doing too great...");
        else if (e.currentHp > 0 && e.currentHp < (this.maxHp * 0.5f))
            Console.WriteLine($"{this.name} needs help!");
        else
            Console.WriteLine($"{this.name} is knocked out!");
    }
}

class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

/// <summary>
/// delegate CalculateHealth that takes a float amount
/// </summary>
/// <param name="amount">float amount to be taken</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Delegate to calculate the modifier state
/// </summary>
/// <param name="baseValue">State value</param>
/// <param name="modifier">value to be applied</param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Group of contants Modifier
/// </summary>
public enum Modifier
{
    /// <summary> Half state </summary>
    Weak,
    /// <summary> Normal state </summary>
    Base,
    /// <summary> Strong state </summary>
    Strong
}
