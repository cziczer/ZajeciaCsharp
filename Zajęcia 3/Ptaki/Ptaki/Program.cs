using System;

namespace Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            Eagle orzelPrawdziwy = new Eagle();
            //orzelPrawdziwy.Hello();
            var orzełJednakPtak = (Bird)orzelPrawdziwy;
            //orzełJednakPtak.Hello();

            IFlyable orzel = new Eagle();
            //orzel.Fly();

            IFlyable[] ptaki = new IFlyable[2];
            ptaki[0] = new Eagle();
            ptaki[1] = new Duck();
            ptaki[1].Fly();
            ptaki[0].Fly();

            var pingwinPingwin = new Penguin();
            pingwinPingwin.Swim();

            var pingwinPtak = (ISwimmable)new Penguin();
            pingwinPtak.Swim();
        }
    }
}
