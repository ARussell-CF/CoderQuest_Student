using CoderQuest_Student.Models;
using CoderQuest_Student.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoderQuest_Student.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            var hero = Hero.Current;
            hero.Name = name;
            return RedirectToAction("MyHero");
        }

        //Custom Hero method
        [HttpPost]
        public ActionResult CustomHero(string name, int str, int def, int hp)
        {
            var hero = Hero.Current;
            hero.Name = name;
            hero.Strength = str;
            hero.Defense = def;
            hero.OriginalHP = hp;
            hero.CurrentHP = hp;
            return RedirectToAction("MyHero");
        }
        public ActionResult MyHero()
        {
            var model = Hero.Current;
            return View(model);
        }
        public ActionResult Fight()
        {
            var model = new FightVM();

            model.Monster = new Monster("Squid", 9, 8, 20);
            model.Hero = Hero.Current;
            return View(model);
        }

        //Add Armor and Weapon Method
        #region Weapons and Armor
        [HttpPost]
        public ActionResult AddArmor(string name, int defense)
        {
            var armor = new Armor(name, defense);
            var hero = Hero.Current;
            hero.ArmorBag.Add(armor);
            return RedirectToAction("MyHero");
        }

        [HttpPost]
        public ActionResult AddWeapon(string name, int strength)
        {
            var weapon = new Weapon(name, strength);
            var hero = Hero.Current;
            hero.WeaponBag.Add(weapon);
            return RedirectToAction("MyHero");
        }

        [HttpPost]
        public ActionResult EquipArmor(string name, int defense)
        {
            var armor = new Armor(name, defense);
            var hero = Hero.Current;
            hero.EquippedArmor = armor;
            return RedirectToAction("MyHero");
        }

        [HttpPost]
        public ActionResult EquipWeapon(string name, int strength)
        {
            var weapon = new Weapon(name, strength);
            var hero = Hero.Current;
            hero.EquippedWeapon = weapon;
            return RedirectToAction("MyHero");
        }
        #endregion

        #region Fight Results
        [HttpPost]
        public ActionResult Run(int hp)
        {
            Hero.Current.CurrentHP = hp;
            return RedirectToAction("MyHero");
        }

        [HttpPost]
        public ActionResult Victory(int hpRemain)
        {
            Hero.Current.CurrentHP = hpRemain;
            return RedirectToAction("MyHero");
        }

        [HttpPost]
        public ActionResult Defeat()
        {
            Hero.Current.CurrentHP = Hero.Current.OriginalHP;
            return RedirectToAction("MyHero");
        }
        #endregion
    }
}