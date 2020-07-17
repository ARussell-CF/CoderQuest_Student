using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoderQuest_Student.Models
{

    [Serializable]
    public sealed class Hero
    {
        #region Singleton
        private static Guid guid = new Guid();
        private static string SESSION_SINGLETON_NAME = $"Singleton_{guid}";

        //original code
        //private const string SESSION_SINGLETON_NAME = "Singleton_502E69E5-668B-E011-951F-00155DF26207";

        private Hero()
        {
            ArmorBag = new List<Armor>();
            WeaponBag = new List<Weapon>();
            Strength = 10;
            Defense = 10;
            OriginalHP = 30;
            CurrentHP = 30;
        }

        public static Hero Current
        {
            get
            {
                if (HttpContext.Current.Session[SESSION_SINGLETON_NAME] == null)
                {
                    HttpContext.Current.Session[SESSION_SINGLETON_NAME] = new Hero();
                }

                return HttpContext.Current.Session[SESSION_SINGLETON_NAME] as Hero;
            }
        }

        #endregion

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public List<Armor> ArmorBag { get; set; }
        public List<Weapon> WeaponBag { get; set; }
    }
}