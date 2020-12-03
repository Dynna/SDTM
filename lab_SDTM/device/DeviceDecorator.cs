using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    class DeviceDecorator : DeviceItem
    {
        protected DeviceItem deviceItem;

        public DeviceDecorator(DeviceItem deviceItem)
        {
            this.deviceItem = deviceItem;
        }

        public override void Display()
        {
            deviceItem.Display();
        }
    }
}
