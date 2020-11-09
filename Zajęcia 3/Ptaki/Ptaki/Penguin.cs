using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    public class Penguin : Bird, ISwimmable, INoFlyable
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
}
