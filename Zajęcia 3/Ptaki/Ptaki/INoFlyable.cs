using System;
using System.Collections.Generic;
using System.Text;

namespace Birds
{
    public interface INoFlyable
    {
        int Weight { get; }

        void CantFly();
    }
}
