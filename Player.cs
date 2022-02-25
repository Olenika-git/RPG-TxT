using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_TxT
{
    class Player
    {
        //  Player Property
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public HashSet<string> ClassList { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        //  Player Constructor
        public Player(string name, int health, int level, HashSet<string> classList, int attack, int defense)
        {
            Name = name;
            Health = health;
            Level = level;
            ClassList = classList;
            Attack = attack;
            Defense = defense;
        }




    }
}
