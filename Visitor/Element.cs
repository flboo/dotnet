namespace Dotnet.Visitor
{
    public interface Element
    {
        void accept(Visitor v);
    }
}