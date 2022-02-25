using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_TxT
{
    class Mob
    {
        //  Mob Property
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        //  Mob Constructor
        public Mob(string name, int health, int level, int attack, int defense)
        {
            Name = name;
            Health = health;
            Level = level;
            Attack = attack;
            Defense = defense;
        }
    }
}
