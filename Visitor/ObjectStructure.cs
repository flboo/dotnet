using System;
using System.Collections.Generic;
namespace Dotnet.Visitor
{
    public class ObjectStructure
    {

        private IList<Element> elements = new List<Element>();
        public void Attach(Element element)
        {
            elements.Add(element);
        }
        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor v)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].accept(v);
            }
        }

        static void Main_v(string[] str)
        {
            ObjectStructure structure = new ObjectStructure();
            structure.Attach(new ConcreteElemetA());
            structure.Attach(new ConcreteElemetB());


            ConcreteVisitorA va = new ConcreteVisitorA();
            ConcreteVisitorB vb = new ConcreteVisitorB();

            structure.Accept(va);
            structure.Accept(vb);

        }
    }


}