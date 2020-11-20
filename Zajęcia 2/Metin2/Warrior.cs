using System;
using System.Collections.Generic;
using System.Text;

namespace Metin2
{
    public class Warrior
    {
        private int _level;
        private int _maxHp;
        bool _hasSword;
        private List<Potion> potions;

        public int Hp { get; set; }
        public int Damage { get; private set; }
        public string Nick { get; }

        public static int HowMany;

        public Warrior(string nick)
        {
            this.Nick = nick;
            this._level = 1;
            this.Hp = 100;
            this._maxHp = 100;
            this._hasSword = false;
            this.Damage = 18;
            this.potions = new List<Potion>(){
                new Potion(10),
                new Potion(10),
                new Potion(15),
                new Potion(30),
            };

            HowMany++;
        }

        public Warrior(string nick, int level, int hp, int dmg, bool hasSword)
        {
            this.Nick = nick;
            this._level = level;
            this._maxHp = hp;
            this.Hp = hp;
            this.Damage = dmg;
            this._hasSword = hasSword;
            this.potions = new List<Potion>(){
                new Potion(10),
                new Potion(10),
                new Potion(15),
                new Potion(30),
            };

            HowMany++;
        }

        public void LevelUp()
        {
            this._level++;
            this._maxHp += 45;
            this.Hp += 45;
            this.Damage += 9;
        }

        public void UsePotion()
        {
            this.Hp += potions[0].HealHp;
            potions.RemoveAt(0);
        }

        public void SayHello()
        {
            Console.WriteLine("Cześć jestem wojownikiem!");
        }

        public void Header()
        {
            Console.WriteLine("Warrior: level: " + this._level + ", nick: " + this.Nick);
        }

        public void Status()
        {
            Console.WriteLine("Warrior HP: " + this.Hp + " Obrazenia: " + this.Damage);
        }

        public void Info()
        {
            this.Header();
            Console.WriteLine("HP: {0} Max HP: {1} Damage: {2} hasSword: {3}",
                this.Hp, this._maxHp, this.Damage, this._hasSword);
        }

        public void Attack(Ninja ninja)
        {
            ninja.Hp -= _hasSword ? this.Damage * 2 : this.Damage;
        }

        //public override string ToString()
        //{
        //    return "Wojownik " + this.Nick;
        //}
    }
}
