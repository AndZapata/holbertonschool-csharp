using System;

namespace Enemies
{
    /// <summary>This class create a Zombie</summary>
    public class Zombie
    {
        /// <summary>How many healt has the zombie</summary>
        private int health;
        private string name = "(No name)";
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
        /// <summary>public property Name</summary>
        public string Name
        {
            get => name;
            set => name = value;
        }
        /// <summary>public method, returns the value of the healt</summary>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>public method toString() for overring the string object</summary>
        public override string ToString() => $"Zombie Name: {name} / Total Health: {health}";
    }
}
