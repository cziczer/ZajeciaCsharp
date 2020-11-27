using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Species
    {
        public IList<Pet> Pets { get; set; }
        public double Cost { get; set; }
        public string Name { get; set; }
    }
}
