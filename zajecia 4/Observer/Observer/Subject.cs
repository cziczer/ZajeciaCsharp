using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Subject : ISubject
    {
        public int Temperature { get; set; }

        private List<IObserver> _observers = new List<IObserver>();


        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (var item in _observers)
            {
                item.UpdateData();
            }
        }

    }

    class Observer : IObserver
    {
        private int _temperature;
        private Subject _subject;

        public Observer(Subject s)
        {
            this._subject = s;
        }

        public void UpdateData()
        {
            _temperature = _subject.Temperature;
            Console.WriteLine("Obiekt pobral temperature rowna {0}", _temperature);
        }
    }
}
