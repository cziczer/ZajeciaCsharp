using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface ISubject
    {


        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }

    public interface IObserver
    {
        void UpdateData();
    }

}
