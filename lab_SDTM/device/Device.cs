using design_patterns.device_factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    class Device : Stock
    {
        public Device(string model, double price)
            : base(model, price)
        {

        }
    }
}
