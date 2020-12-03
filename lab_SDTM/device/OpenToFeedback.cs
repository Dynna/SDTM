using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    class OpenToFeedback : DeviceDecorator
    {
        protected List<string> customers = new List<string>();

        public OpenToFeedback(DeviceItem deviceItem)
          : base(deviceItem)
        {
        }

        public void RateItem(string name)
        {
            customers.Add(name);
            deviceItem.NumCopies--;
        }

        public override void Display()
        {
            base.Display();

            foreach (string customer in customers)
            {
                Console.WriteLine(" customer: " + customer);
            }
        }
    }
}

