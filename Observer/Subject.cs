using System;
using System.Collections.Generic;
namespace Dotnet.Observer
{
    public abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (Observer item in observers)
            {
                item.Update();
            }
        }

    }
}