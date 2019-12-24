using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer observer1 = new Observer(subject);
            Observer observer2 = new Observer(subject);

            subject.AddObserver(observer1);
            subject.AddObserver(observer2);

            subject.Temperature = 22;

            subject.NotifyObserver();

            subject.RemoveObserver(observer1);

            subject.Temperature = 13;

            subject.NotifyObserver();


            Console.ReadLine();
        }
    }
}
