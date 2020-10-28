using System;
using System.Collections.Generic;
using System.Text;

namespace Metin2
{
    class Potion
    {
        public int HealHp { get; }

        public Potion(int heal)
        {
            this.HealHp = heal;
        }
    }
}
