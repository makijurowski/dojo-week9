using System;
using System.Collections.Generic;

namespace terminal_rpg {
    // Parent class
    public class Human {
        
        // Properties for Human class
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }

        // Constructor for Human class with default values added (only passes name as argument)
        public Human (string name) {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        // Constructor for Human class without default values (passes all stats as arguments)
        public Human (string name, int strength, int intelligence, int dexterity, int health) {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        // Method to show the status of the current player
        public void ShowStatus () {
            System.Console.WriteLine ("Name: {0}", Name);
            System.Console.WriteLine ("Strength: {0}", Strength);
            System.Console.WriteLine ("Intelligence: {0}", Intelligence);
            System.Console.WriteLine ("Dexterity: {0}", Dexterity);
            System.Console.WriteLine ("Health: {0}", Health);
        }

        // Method used to attack another player passed by reference
        public void Attack (object obj) {
            Human enemy = obj as Human;
            if (enemy == null) {
                System.Console.WriteLine ("Attack failed. This player does not exist.");
            } else {
                enemy.Health -= Strength * 5;
            }
        }
    }

    // Child class Wizard which inherits from Human
    public class Wizard : Human {
        
        // Constructor for Wizard that only takes in name as parameter but sets new defaults for other properties of type Human
        public Wizard (string name) : base (name) {
            Intelligence = 25;
            Health = 50;
        }

        // Method used to restore health to the Wizard who invokes it
        public void Heal () {
            this.Health += Intelligence * 5;
        }

        // Method used to attack another player passed by reference
        public void Fireball (object obj) {
            Human enemy = obj as Human;
            Random random = new Random ();
            if (enemy == null) {
                System.Console.WriteLine ("Fireball failed. This player does not exist.");
            } else {
                int damage = random.Next (20, 51);
                enemy.Health -= damage;
            }
        }
    }

    // Child class Samurai which inherits from Human
    public class Samurai : Human {
        
        // Add a new property to Samurai to keep count for How_Many function
        public static int Samurai_Count = 0;

        // Constructor for Samurai that only takes in name as parameter but sets new defaults for other properties of type Human
        public Samurai (string name) : base (name) {
            Health = 200;
            Samurai_Count += 1;
        }

        // Method used to log the number of samurais that have been created
        public static void How_Many () {
            System.Console.WriteLine ("Number of Samurais: {0}", Samurai_Count);
        }

        // Method used to restore health to the Samurai who invokes it
        public void Meditate () {
            this.Health = 200;
        }

        // Method used to attack another player passed by reference
        public void Death_Blow (object obj) {
            Human enemy = obj as Human;
            if (enemy == null) {
                System.Console.WriteLine ("Death_Blow failed. This player does not exist.");
            } else if (enemy.Health < 50) {
                enemy.Health = 0;
            } else {
                System.Console.WriteLine ("Death_Blow failed. This player has over 50 health.");
            }
        }
    }

    // Child class Ninja which inherits from Human
    public class Ninja : Human {
        
        // Constructor for Ninja which only takes name as parameter but sets new default for property of Human
        public Ninja (string name) : base (name) {
            Dexterity = 175;
        }

        // Method used for the Ninja to escape, decreasing their health
        public void Get_Away () {
            this.Health -= 15;
        }

        // Method used to attack another player (passed by referenc) and restore health to Ninja who invokes it
        public void Steal (object obj) {
            Human enemy = obj as Human;
            if (enemy == null) {
                System.Console.WriteLine ("Steal failed. This player does not exist.");
            } else {
                this.Attack (enemy);
                this.Health += 10;
            }
        }
    }

    class Program {
        static void Main (string[] args) {
            // Create new players
            Human me = new Human ("Maki");
            me.Health = 200;
            Human Lola = new Human ("Lola");
            Wizard Wanda = new Wizard ("Wanda");
            Ninja Nick = new Ninja ("Nick");
            Samurai Sam = new Samurai ("Sam");
            Samurai Ducky = new Samurai ("Ducky");

            // Show stats of players at beginning of game
            System.Console.WriteLine ("\n=====Before Attacking======");
            System.Console.WriteLine ("\n---------Player 1----------");
            me.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 2----------");
            Lola.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 3----------");
            Wanda.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 4----------");
            Nick.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 5----------");
            Sam.ShowStatus ();

            // Attack round
            System.Console.WriteLine ("\n======While Attacking======");
            Wanda.Fireball (me);
            System.Console.WriteLine ("\n1. Wanda fireballs me.");
            me.Attack (Lola);
            System.Console.WriteLine ("\n2. I attack Lola.");
            Lola.Attack (Wanda);
            System.Console.WriteLine ("\n3. Lola attacks Wanda.");
            Sam.Death_Blow (Wanda);
            System.Console.WriteLine ("\n4. Sam death blows Wanda. (Suck it Wanda!)");
            Nick.Steal (Sam);
            System.Console.WriteLine ("\n5. Nick steals from Sam.");

            // Show stats of players after attacking
            System.Console.WriteLine ("\n======After Attacking======");
            System.Console.WriteLine ("\n---------Player 1----------");
            me.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 2----------");
            Lola.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 3----------");
            Wanda.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 4----------");
            Nick.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 5----------");
            Sam.ShowStatus ();

            // Heal round
            System.Console.WriteLine ("\n=======While Healing=======");
            Wanda.Heal ();
            System.Console.WriteLine ("\n1. Wanda uses heal on herself.");
            Sam.Meditate ();
            System.Console.WriteLine ("\n2. Sam uses meditate on himself.");
            System.Console.WriteLine ("\n=======After Healing=======");
            System.Console.WriteLine ("\n---------Player 3----------");
            Wanda.ShowStatus ();
            System.Console.WriteLine ("\n---------Player 5----------");
            Sam.ShowStatus ();
            System.Console.WriteLine ("\n");
            Samurai.How_Many ();
        }
    }
}