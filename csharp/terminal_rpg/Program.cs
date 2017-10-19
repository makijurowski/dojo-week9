using System;

namespace terminal_rpg
{
    class Program
    {
        // Main method invoked upon running program
        static void Main(string[] args)
        {
            // Create new players
            Human me = new Human("Maki");
            me.Health = 200;
            Human Lola = new Human("Lola");
            Wizard Wanda = new Wizard("Wanda");
            Ninja Nick = new Ninja("Nick");
            Samurai Sam = new Samurai("Sam");
            Samurai Ducky = new Samurai("Ducky");
            Scribe Steve = new Scribe("Steve");

            // Show stats of players at beginning of game
            System.Console.WriteLine("\n=====Before Attacking======");
            System.Console.WriteLine("\n---------Player 1----------");
            me.ShowStatus();
            System.Console.WriteLine("\n---------Player 2----------");
            Lola.ShowStatus();
            System.Console.WriteLine("\n---------Player 3----------");
            Wanda.ShowStatus();
            System.Console.WriteLine("\n---------Player 4----------");
            Nick.ShowStatus();
            System.Console.WriteLine("\n---------Player 5----------");
            Sam.ShowStatus();
            System.Console.WriteLine("\n---------Player 6-----------");
            Steve.ShowStatus();

            // Attack round
            System.Console.WriteLine("\n======While Attacking======");
            Wanda.Fireball(me);
            System.Console.WriteLine("\n1. Wanda fireballs me.");
            me.Attack(Lola);
            System.Console.WriteLine("\n2. I attack Lola.");
            Lola.Attack(Wanda);
            System.Console.WriteLine("\n3. Lola attacks Wanda.");
            Sam.Death_Blow(Wanda);
            System.Console.WriteLine("\n4. Sam death blows Wanda. (Suck it Wanda!)");
            Nick.Steal(Sam);
            System.Console.WriteLine("\n5. Nick steals from Sam.");

            // Show stats of players after attacking
            System.Console.WriteLine("\n======After Attacking======");
            System.Console.WriteLine("\n---------Player 1----------");
            me.ShowStatus();
            System.Console.WriteLine("\n---------Player 2----------");
            Lola.ShowStatus();
            System.Console.WriteLine("\n---------Player 3----------");
            Wanda.ShowStatus();
            System.Console.WriteLine("\n---------Player 4----------");
            Nick.ShowStatus();
            System.Console.WriteLine("\n---------Player 5----------");
            Sam.ShowStatus();

            // Heal round
            System.Console.WriteLine("\n=======While Healing=======");
            Wanda.Heal();
            System.Console.WriteLine("\n1. Wanda uses heal on herself.");
            Sam.Meditate();
            System.Console.WriteLine("\n2. Sam uses meditate on himself.");

            // Show stats of players after healing
            System.Console.WriteLine("\n=======After Healing=======");
            System.Console.WriteLine("\n---------Player 3----------");
            Wanda.ShowStatus();
            System.Console.WriteLine("\n---------Player 5----------");
            Sam.ShowStatus();
            System.Console.WriteLine("\n");
            Samurai.How_Many();
        }
    }
}