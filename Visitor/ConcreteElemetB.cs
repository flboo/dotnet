namespace Dotnet.Visitor
{
    public class ConcreteElemetB : Element
    {
        public void accept(Visitor v)
        {
            v.VisitConcreteElementB(this);
        }

        public void OperationB()
        {

        }
    }
}