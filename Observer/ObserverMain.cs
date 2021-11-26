namespace Dotnet.Observer
{
    public class ObserverMain
    {
        //观察者模式模式
        static void Main(string[] str)
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "x"));
            s.Attach(new ConcreteObserver(s, "y"));
            s.Attach(new ConcreteObserver(s, "z"));

            s.SubjectState = "xyzzzzz";
            s.Notify();
        }
    }
}