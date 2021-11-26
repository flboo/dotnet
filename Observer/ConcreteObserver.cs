using System;
namespace Dotnet.Observer
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private string subjectState;
        private ConcreteSubject concreteSubject;
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.name = name;
            this.concreteSubject = subject;
        }


        public override void Update()
        {
            subjectState = concreteSubject.subjectState;
            Log.i(string.Format("观察者{0}的状态是{1}", name, subjectState));
        }

        public ConcreteSubject ConcreteSubject
        {
            get { return concreteSubject; }
            set { concreteSubject = value; }
        }

    }
}