using System;
using System.Collections.Generic;
using System.Text;

namespace Ptaki
{
    public interface IRun   
    {
        void Run();
    }

    public interface ISwimmable
    {
        int Weight { get; }

        void Swim();
    }

    public interface IFlyable
    {
        int Weight { get; }

        void Fly();
    }

    public interface INoFlyable
    {
        int Weight { get; }

        void CantFly();
    }
}
