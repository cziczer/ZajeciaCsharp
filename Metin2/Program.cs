using System;
using System.Threading;

namespace Metin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja1 = new Ninja("Ninja1");
            Wojownik wojownik1 = new Wojownik("wojownik1");
            wojownik1.helloW();
            wojownik1.Header();
            Wojownik wojownik2 = new Wojownik("wojownik2", 5, 240, 40, 0, true);
            Ninja ninja2 = new Ninja("ninja2", 6, 300, 30, 2, false);
            wojownik1.info();
            ninja1.info();
            Thread.Sleep(2000);

            ninja1.hp += 100;
            ninja1.info();
            Thread.Sleep(2000);

            wojownik1.levelUp();
            wojownik1.info();
            Thread.Sleep(2000);

            while (ninja2.hp > 0 && wojownik2.hp > 0)
            {
                wojownik2.attack(ninja2);
                if (ninja2.hp <= 0)
                    break;
                ninja2.attack(wojownik2);
                wojownik2.Status();
                ninja2.Status();
                Console.WriteLine();
                Thread.Sleep(2000);
            }
            ninja2.info();
            wojownik2.info();

            Console.WriteLine(wojownik1);

            Console.WriteLine((int)Day.Poniedzialek);

            Console.ReadKey();
        }
    }

    enum Day
    {
        Poniedzialek = 5,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek,
        Sobota,
        Niedziela
    };
}
