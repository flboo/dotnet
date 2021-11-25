namespace Dotnet.Mediator
{
    //抽象中介类
    public abstract class Mediator
    {
        public abstract void Send(string str, Colleague colleague);
    }
}