using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    public class Duck : Bird, IFlyable
    {
        public int Weight { get; }

        public void Fly()
        {
            Console.WriteLine("Jestem kaczką, latam");
        }
    }
}
