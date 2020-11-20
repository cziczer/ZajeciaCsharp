using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metin2
{
    public class Ninja
    {
        private int _level;
        private int _maxHp;
        bool _hasBow;
        private List<Potion> potions;

        public int Hp { get; set; }
        public int Damage { get; private set; }
        public string Nick { get; }

        public Day LuckyDay;

        private int _luckyNumber;

        public int LuckyNumber
        {
            get { return _luckyNumber; }
            set
            {
                if (value > 10) this._luckyNumber = value;
                else this._luckyNumber = value * 2;
            }
        }

        //public Ninja()
        //{
        //    this.Nick = "Tomek";
        //    this._level = 1;
        //    this.Hp = 100;
        //    this._maxHp = 100;
        //    this._hasBow = false;
        //    this.Damage = 10;
        //    this.potions = new List<Potion>(){
        //        new Potion(10),
        //        new Potion(10),
        //        new Potion(15),
        //        new Potion(30),
        //    };
        //}

        //public Ninja(string nick, int level, int hp, int dmg, bool hasBow)
        //{
        //    this.Nick = nick;
        //    this._level = level;
        //    this._maxHp = hp;
        //    this.Hp = hp;
        //    this.Damage = dmg;
        //    this._hasBow = hasBow;
        //    this.potions = new List<Potion>()
        //    {
        //        new Potion(10),
        //        new Potion(10),
        //        new Potion(15),
        //        new Potion(30),
        //    };
        //}

        public void LevelUp()
        {
            this._level++;
            this._maxHp += 50;
            this.Hp += 50;
            this.Damage += 5;
        }

        public void UsePotion()
        {
            this.Hp += potions[0].HealHp;
            potions.RemoveAt(0);
        }

        public void SayHello()
        {
            Console.WriteLine("Cześć jestem ninją!");
        }

        public void Header()
        {
            Console.WriteLine("Ninja level: " + this._level + ", nick: " + this.Nick);
        }

        public void Status()
        {
            Console.WriteLine("Ninja HP: " + this.Hp + " obrażenia: " + this.Damage);
        }

        public void Info()
        {
            this.Header();
            Console.WriteLine("HP: {0} Max HP: {1} Damage: {2} hasBow: {3}",
                this.Hp, this._maxHp, this.Damage, this._hasBow);
        }

        public void Attack(Warrior warrior)
        { 
            warrior.Hp -= _hasBow ? this.Damage * 2 : this.Damage;
        }

        public override string ToString()
        {
            return "Ninja " + this.Nick;
        }
    }
}
