using System;
using System.Collections.Generic;

namespace human
{
    class Program
    {
        public class Human
        {
            public string Name { get; set; }
            public int Strength { get; set; }
            public int Intelligence { get; set; }
            public int Dexterity { get; set; }
            public int Health{ get; set; }

            public Human(string name, int strength=3, int intelligence=3, int dexterity=3, int health=100) 
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                Health = health;
            }

            public void ShowStatus() {
                System.Console.WriteLine("Name: {0}", Name);
                System.Console.WriteLine("Strength: {0}", Strength);
                System.Console.WriteLine("Intelligence: {0}", Intelligence);
                System.Console.WriteLine("Dexterity: {0}", Dexterity);
                System.Console.WriteLine("Health: {0}", Health);
            }

            public void Attack(Human human)
            {
                human.Health -= (this.Strength * 5);
            }
        }

        static void Main(string[] args)
        {
            // Human me = new Human("Maki", 3, 10, 3, 200);
            Human me = new Human("Maki", health: 200);
            Human Lola = new Human("Lola");
            System.Console.WriteLine(me);
            System.Console.WriteLine("--------Before Attacking--------");
            me.ShowStatus();
            System.Console.WriteLine("--------------------------------");
            Lola.ShowStatus();
            System.Console.WriteLine("--------After Attacking---------");
            me.Attack(Lola);
            Lola.ShowStatus();
            System.Console.WriteLine("--------------------------------");
        }
    }
}
