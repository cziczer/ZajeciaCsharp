using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    class Emu : INoFlyable
    {
        public int Weight { get; }

        public void CantFly()
        {
            Console.WriteLine("Też nie umiem latać, ale szybko biegam");
        }
    }
}
