using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderQuest_Student.Models
{
    public class Armor
    {
        public Armor(string name, int defense)
        {
            this.Name = name;
            this.Defense = defense;
        }

        public string Name { get; set; }
        public int Defense { get; set; }
    }
}