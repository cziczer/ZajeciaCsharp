using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    // where T : IComparable
    // where T : ClassName
    // where T : struct
    // where T : class
    // where T : new()
    public class GenericExample<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}

