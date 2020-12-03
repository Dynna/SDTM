using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.order
{
    class PrimitiveElement : AddingElement
    {
        public PrimitiveElement(string device)
         : base(device)
        {
        }

        public override void Add(AddingElement c)
        {
            Console.WriteLine(
              "Cannot add to a PrimitiveElement");
        }

        public override void Remove(AddingElement c)
        {
            Console.WriteLine(
              "Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _device);
        }
    }
}
