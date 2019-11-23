using System;

namespace Ptaki
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable orzel = new Eagle();
            IFlyable[] ptaki = new IFlyable[2];
            ptaki[0] = new Eagle();
            ptaki[1] = new Duck();
            ptaki[1].Fly();
            ptaki[0].Fly();
            Eagle orzel2 = new Eagle();
            orzel2.Run();

        }

    }
}
