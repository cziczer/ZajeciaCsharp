using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    public interface ISwimmable
    {
        int Weight { get; }

        void Swim();
    }
}
