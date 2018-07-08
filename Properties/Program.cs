using System;

namespace Properties
{
    class Player
    {
        public bool isAlive = true;  // using reguler data memeber
        public bool IsAlive          // using properity -- it embed fubctionality into get and set
        {
            get { return health > 0; }
            // There is no set(), therefore, this propirety can't be set
        }
        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }

        public void CheckDeath()  // Needed only for the reguler data member
        {
            if (health <= 0)
                isAlive = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            for(int i = 0; i < 20; i++)
            {
                player.Hit();
                /* in case rguler data member
                player.CheckDeath();
                Console.WriteLine("Is a player a live: " + player.isAlive);
                */
                // In case using properity -- much better
                Console.WriteLine("Is a player a live: " + player.IsAlive);
            }
        }
    }
}
