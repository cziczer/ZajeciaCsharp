using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Ptaki
{
    class Ptak : IRun
    {
        public int Speed { get; set; }

        public void Hello()
        {
            Console.WriteLine("Cześć jestem ptakiem!");
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }
    }

    class Eagle : Ptak, IFlyable
    {
        public void Hello() 
        {
            Console.WriteLine("Jestem orłem, latam szybko");
        }

        public void Run()
        {
            Console.WriteLine("AAAAAAAAAA");
        }

        public int Weight { get; private set; }
        public void Fly()
        {
            Console.WriteLine("Lece sobie ");
        }
    }

    class Penguin : Ptak, ISwimmable, INoFlyable
    {
        public void CantFly()
        {
            Console.WriteLine("Sorry, nie umiem latać:/'");
        }

        public int Weight { get; }

        public void Swim()
        {
            Console.WriteLine("Jestem pingwinem, nie umiem latać ale szybko pływam");
        }
    }

    class Emu : INoFlyable
    {
        public int Weight { get; }
        public void CantFly()
        {
            Console.WriteLine("Też nie umiem latać, ale szybko biegam");
        }
    }
    class Duck : Ptak, IFlyable
    {
        public int Weight { get; }

        public void Fly()
        {
            Console.WriteLine("Jestem kaczką, latam");
        }
    }

   
}
