namespace Dotnet.Visitor
{
    public class ConcreteElemetA : Element
    {
        public void accept(Visitor v)
        {
            v.VisitConcreteElementA(this);
        }


        public void OperationA()
        {

        }
    }
}