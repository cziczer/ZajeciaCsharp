using System;
using System.Collections.Generic;
using System.Text;

namespace Metin2
{
    class Wojownik
    {
        private int level;
        public int hp;
        private int maxHp;
        public bool sword;
        public int Potions { get; set; }
        public int Damage { get; private set; }
        public string Nick { get; }
        public static int howMany;

        public Wojownik(string nick)
        {
            this.Nick = nick;
            this.level = 1;
            this.hp = 100;
            this.maxHp = 100;
            this.sword = false;
            this.Damage = 18;
            this.Potions = 0;
            howMany++;
        }
        public Wojownik(string nick, int level, int hp, int dmg, int pot, bool sword)
        {
            this.Nick = nick;
            this.level = level;
            this.maxHp = hp;
            this.hp = hp;
            this.Damage = dmg;
            this.Potions = pot;
            this.sword = sword;
            howMany++;
        }

        public void helloW()
        {
            Console.WriteLine("Cześć jestem wojonikiem!");
        }

        public void levelUp()
        {
            this.level++;
            this.maxHp += 45;
            this.hp += 45;
            this.Damage += 9;

        }

        public void Header()
        {
            Console.WriteLine("Wojownik: level: " + this.level + ", nick: " + this.Nick);
        }

        public void Status()
        {
            Console.WriteLine("Wojownik HP: " + this.hp + " Obrazenia: " + this.Damage);
        }

        public void info()
        {
            this.Header();
            Console.WriteLine("HP: {0} Max HP: {1} Damage: {2} Sword: {3} Potions: {4}",
                        this.hp, this.maxHp, this.Damage, this.sword, this.Potions);
        }

        public void attack(Ninja ninja)
        {
            if (this.sword)
                ninja.hp -= this.Damage + 15;
            else
                ninja.hp -= this.Damage;
        }

        public override string ToString()
        {
            return "Wojownik " + this.Nick;
        }
    }
}
