namespace Dotnet.Mediator
{
    public class ConcretteColleague2 : Colleague
    {
        public ConcretteColleague2(Mediator mediator) : base(mediator)
        {

        }
        public void Send(string str)
        {
            mediator.Send(str, this);
        }

        public void Notify(string str)
        {
            Log.i("同事2得到的消息" + str);
        }
    }
}