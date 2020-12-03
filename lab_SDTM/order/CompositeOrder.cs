using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.order
{
    class CompositeOrder : AddingElement
    {
        private List<AddingElement> elements = new List<AddingElement>();

        public CompositeOrder(string device)
          : base(device)
        {
        }

        public override void Add(AddingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(AddingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "* " + _device);

            foreach (AddingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}

