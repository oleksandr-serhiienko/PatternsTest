using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsebility
{
    public class Creature
    {
        public string Name;
        public int Atack, Defense;

        public Creature(string name, int attack, int defense)
        {
            Name = name;
            Atack = attack;
            Defense = defense;
        }
    }
}
