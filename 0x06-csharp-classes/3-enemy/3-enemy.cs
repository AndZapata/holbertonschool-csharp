using System;

namespace Enemies
{
    /// <summary>This class create a Zombie</summary>
    public class Zombie
    {
        /// <summary>How many healt has the zombie</summary>
        int health;
        /// <summary>Constructor for the healt of the zombie</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>Constructor that checks the value</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
        /// <summary>public method, returns the value of the healt</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
