using System;
using System.Threading;

namespace Metin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja = new Ninja("Tomek");
            Warrior warrior = new Warrior("Maciek");

            Ninja anotherTomek = new Ninja("Tomek");
            Ninja sameTome = anotherTomek;

            //Console.WriteLine(ninja == anotherTomek);
            //Console.WriteLine(anotherTomek == sameTome);

            //warrior.Header();
            //ninja.Header();

            //Console.WriteLine(ninja.LuckyNumber);
            //Console.WriteLine(ninja.LuckyNumber = 6);
            //Console.WriteLine(ninja.LuckyNumber);
            //Console.WriteLine(ninja.LuckyNumber = 11);

            //ninja.Status();
            //ninja.UsePotion();
            //ninja.Status();

            Warrior fatWarrior = new Warrior("Baron", 5, 240, 40, true);
            Ninja strongNinja = new Ninja("Assasin", 6, 300, 30, false);


            //ninja.Info();
            //warrior.Info();

            //ninja.Hp += 100; // Czy to jest dobre?
            //ninja.Info();

            //warrior.LevelUp();
            //warrior.Info();

            //strongNinja.UsePotion();
            //strongNinja.UsePotion();

            //while (strongNinja.Hp > 0 && fatWarrior.Hp > 0)
            //{
            //    fatWarrior.Attack(strongNinja);
            //    if (strongNinja.Hp <= 0)
            //        break;
            //    strongNinja.Attack(fatWarrior);
            //    fatWarrior.Status();
            //    strongNinja.Status();
            //    Console.WriteLine();
            //    Thread.Sleep(2000);
            //}
            //strongNinja.Info();
            //fatWarrior.Info();

            //Console.WriteLine(warrior);

            //ENUMY

            //Console.WriteLine(Day.Poniedzialek);
            //Console.WriteLine((int)Day.Poniedzialek);

            //var firstDay = (Day) 4;
            //var secondDay = Day.Sobota;
            //var Sunday = secondDay + 1;
            //Console.WriteLine(Sunday);

            //var sumDays = (Day) (int)firstDay + (int)secondDay;
            //Console.WriteLine(sumDays);
            //Console.WriteLine(sumDays.ToString());
            //var anotherSumDays = secondDay + 13;
            //Console.WriteLine(anotherSumDays);
        }
    }
}
