using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    abstract class Dog : Animal
    {
        public Dog(string name) : base(name)
        { }

        public void FindCat()
        {
            Console.WriteLine($"Jestem {base.Name}, szukam teraz kota, przypominam jestem {this.Name}!");
        }
    }
}
