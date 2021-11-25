namespace Dotnet.Mediator
{
    public class ConcretteColleague1 : Colleague
    {
        public ConcretteColleague1(Mediator mediator) : base(mediator)
        {

        }

        public void Send(string str)
        {
            mediator.Send(str, this);
        }

        public void Notify(string str)
        {
            Log.i("同事1得到的消息" + str);
        }
    }
}