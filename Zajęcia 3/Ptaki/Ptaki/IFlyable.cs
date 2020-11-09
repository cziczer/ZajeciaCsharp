using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    public interface IFlyable
    {
        int Weight { get; }

        void Fly();
    }
}
