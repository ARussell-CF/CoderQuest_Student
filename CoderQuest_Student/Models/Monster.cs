using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderQuest_Student.Models
{
    public class Monster
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }

        public Monster(string name, int str, int def, int hp)
        {
            Name = name;
            Strength = str;
            Defense = def;
            OriginalHP = hp;
            CurrentHP = OriginalHP;
        }
    }
}