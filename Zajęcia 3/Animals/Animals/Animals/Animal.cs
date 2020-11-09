using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    abstract class Animal
    {
        protected string Name;

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Eat();

        //public void WakeUp()
        public virtual void WakeUp()
        {
            Console.WriteLine("Don't sleep anymore");
        }
    }
}
