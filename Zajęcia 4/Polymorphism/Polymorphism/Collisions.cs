using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // First
    interface IPaint
    {
        void Paint(); 
        int Mystery { get; }
    }

    interface ISurface
    {
        void Paint();
        int Mystery();
    }

    class ExampleClass : IPaint, ISurface
    {
        public void Paint()
        {
            Console.WriteLine("Paint method in ExampleClass");
        }

        //void IPaint.Paint()
        //{
        //    Console.WriteLine("IPaint");
        //}

        //void ISurface.Paint()
        //{
        //    Console.WriteLine("ISurface");
        //}

        int IPaint.Mystery { get; }

        public int Mystery()
        {
            return 5;
        }
    }
}
