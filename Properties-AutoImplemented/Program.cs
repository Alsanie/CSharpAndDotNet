using System;

namespace Properties
{
    class Player
    {
        public bool isAlive = true;  // using reguler data memeber
        public bool IsAlive          // using properity -- it embed fubctionality into get and set
        {
            get { return Health12 > 0; }
            // There is no set(), therefore, this propirety can't be set
        }

        // Not a propirety
        int health = 100;

        // A propirety with manula implemntation
        public int Health1
        {
            get { return Health1; }
            // The probpem that we dont want to have a public set()
            // Then how we can set it, even our class member cab't set it :(
        }

        // A propirety with auto implemntation
        public int Health12 { get; private set; } = 100;   // With auto initialization and private set()

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine("Is a player a live: " + player.IsAlive);
            }
        }
    }
}
