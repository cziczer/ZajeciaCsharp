using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Birds
{
    public class Bird : IRunnable
    {
        public int Speed { get; set; }

        public void Hello()
        {
            Console.WriteLine("Cześć jestem ptakiem!");
        }

        public void Run()
        {
            Console.WriteLine("Bird biegnie do gniazda");
        }
    }
}
