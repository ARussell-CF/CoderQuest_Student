using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderQuest_Student.Models
{
    public class Weapon
    {
        public Weapon(string name, int strength)
        {
            this.Name = name;
            this.Strength = strength;
        }

        public string Name { get; set; }
        public int Strength { get; set; }
    }
}
