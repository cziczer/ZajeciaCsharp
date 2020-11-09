using System;
using System.Collections.Generic;
using System.Text;
using Console = System.Console;

namespace Animals
{
    class GermanShepherd : Dog
    {
        public GermanShepherd(string imie) : base(imie)
        { }

        public override void Eat()
        {
            Console.WriteLine("Pyszna karma");
        }

        public override void WakeUp()
        //public void WakeUp()
        {
            Console.WriteLine("I never sleep!");
        }
    }
}
