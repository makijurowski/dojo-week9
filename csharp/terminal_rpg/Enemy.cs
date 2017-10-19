using System;

namespace terminal_rpg {
    // Child class Enemy which inherits from Human
    public class Enemy : Human {
        // Constructor for Enemy
        public Enemy(string name) : base(name) {
            Health = 300;
        }
    }
}