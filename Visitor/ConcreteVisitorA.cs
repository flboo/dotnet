namespace Dotnet.Visitor
{
    public class ConcreteVisitorA : Visitor
    {
        public override void VisitConcreteElementA(ConcreteElemetA elemetA)
        {
            Log.i(elemetA.GetType().Name + "  " + this.GetType().Name);
        }
        public override void VisitConcreteElementB(ConcreteElemetB elemetB)
        {
            Log.i(elemetB.GetType().Name + "  " + this.GetType().Name);
        }

    }
}