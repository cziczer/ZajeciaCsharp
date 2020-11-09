using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    public class Eagle : Bird, IFlyable
    {
        public void Hello()
        {
            Console.WriteLine("Jestem orłem, latam szybko");
        }

        public int Weight { get; private set; }

        public void Fly()
        {
            Console.WriteLine("orzeł leci :D");
        }
    }
}
