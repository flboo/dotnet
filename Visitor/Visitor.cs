namespace Dotnet.Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElemetA elemetA);
        public abstract void VisitConcreteElementB(ConcreteElemetB elemetB);

    }
}