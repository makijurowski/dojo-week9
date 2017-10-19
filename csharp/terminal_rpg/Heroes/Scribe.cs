using System;

namespace terminal_rpg
{
    // Child class Scribe which inherits from Human
    public class Scribe : Human
    {
        // Constructor for Scribe which only takes name as parameter but sets new default for property of Human
        public Scribe(string name) : base(name)
        {
            Health = 150;
        }

        // Method used for the Scribe to heal, increasing their health
        public void Write_Poetry()
        {
            this.Health += 15;
        }

        // Method used to attack another player (passed by reference)
        public void Stab(object obj)
        {
            Human enemy = obj as Human;
            if (enemy == null)
            {
                System.Console.WriteLine("Stab failed. This player does not exist.");
            }
            else
            {
                this.Attack(enemy);
                // this.Health += 10;
            }
        }
    }
}