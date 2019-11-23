using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    // First
    interface IPaint
    {
        void Paint();
    }
    interface ISurface
    {
        void Paint();
    }
    class ExampleClass : IPaint, ISurface
    {
        public void Paint()
        {
            Console.WriteLine("Paint method in ExampleClass");
        }

        void IPaint.Paint()
        {
            Console.WriteLine("IPaint");
        }

        void ISurface.Paint()
        {
            Console.WriteLine("ISurface");
        }

    }

    //// 
 
    interface ILeft
    {
    int P { get; }
    }
    interface IRight
    {
        int P();
    }

    class Middle : ILeft, IRight
    {
        int ILeft.P { get; }
    
        public int P()
        {
            return 0;
        }
        
    }
}

