using System;
using System.Xml.Serialization;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog("Pieseł"); // :/

            Dachshund jamnik = new Dachshund("Hot Dog");

            GermanShepherd alex = new GermanShepherd("Komisarz Alex");

            //jamnik.WakeUp();
            //alex.WakeUp();

            //Console.WriteLine("Alex animal: ");
            var alexAnimal = (Animal)alex;

            //alexAnimal.WakeUp();

            alex.Eat();
            jamnik.Eat();
            alexAnimal.Eat();

            alex.FindCat();
            jamnik.FindCat();
        }
    }
}
