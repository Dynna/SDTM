using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.order
{
    abstract class AddingElement
    {
        protected string _device;

        public AddingElement(string device)
        {
            this._device = device;
        }

        public abstract void Add(AddingElement d);
        public abstract void Remove(AddingElement d);
        public abstract void Display(int indent);
    }
}
