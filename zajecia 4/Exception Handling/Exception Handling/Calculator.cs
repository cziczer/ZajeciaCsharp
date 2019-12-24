using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    class Calculator
    {
        public int Divide(int numerator, int denomenator)
        {
            if (numerator == 0)
                throw (new ZeroNumerator("Zero Numerator!!"));
            return numerator / denomenator;
        }
    }
    public class ZeroNumerator : Exception
    {
        public ZeroNumerator(string message) : base(message)
        {
        }
    }
}
