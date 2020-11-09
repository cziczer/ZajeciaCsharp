using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dachshund : Dog
    {
        public Dachshund(string imie) : base(imie)
        {
        }

        //public Dachshund(string name)
        //{
        //    this.Name = name;
        //}

        public override void Eat()
        {
            Console.WriteLine("Wolałbym jakieś dobre mięsko");
        }

        public new void FindCat()
        {
            Console.WriteLine("W sumie nie chce mi się nikogo gonić");
        }
    }
}
