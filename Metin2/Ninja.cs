using System;
using System.Collections.Generic;
using System.Text;

namespace Metin2
{
    class Ninja
    {
        private int level;
        public int hp;
        private int maxHp;
        public bool bow;
        public int Potions { get; set; }
        public int Damage { get; private set; }
        public string Nick { get; }

        public Ninja(string nick)
        {
            this.Nick = nick;
            this.level = 1;
            this.hp = 100;
            this.maxHp = 100;
            this.bow = false;
            this.Damage = 10;
            this.Potions = 0;
        }
        public Ninja(string nick, int level, int hp, int dmg, int pot, bool bow)
        {
            this.Nick = nick;
            this.level = level;
            this.maxHp = hp;
            this.hp = hp;
            this.Damage = dmg;
            this.Potions = pot;
            this.bow = bow;
        }

        public void helloN()
        {
            Console.WriteLine("Cześć jestem ninją!");
        }

        public void levelUp()
        {
            this.level++;
            this.maxHp += 50;
            this.hp += 50;
            this.Damage += 5;

        }

        public void Header()
        {
            Console.WriteLine("Ninja level: " + this.level + ", nick: " + this.Nick);
        }

        public void Status()
        {
            Console.WriteLine("Ninja HP: " + this.hp + " Obrazenia: " + this.Damage);
        }

        public void info()
        {
            this.Header();
            Console.WriteLine("HP: {0} Max HP: {1} Damage: {2} bow: {3} Potions: {4}",
                this.hp, this.maxHp, this.Damage, this.bow, this.Potions);
        }

        public void attack(Wojownik wojownik)
        {
            if (this.bow)
                wojownik.hp -= this.Damage * 2;
            else
                wojownik.hp -= this.Damage;
            this.hp += 7;
        }

        public override string ToString()
        {
            return "Ninja " + this.Nick;
        }
    }
}
