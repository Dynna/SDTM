using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    class Client
    {
        private ISmartphone smartphone;
        private ITablet tablet;

        public Client(IDeviceFactory factory, string series)
        {
            smartphone = factory.ManufactureSmartphone(series);
            tablet = factory.ManufactureTablet(series);
        }

        public string GetManufacturedSmartphoneName()
        {
            return smartphone.Name();
        }

        public string GetManufacturedTabletName()
        {
            return tablet.Name();
        }
    }
}
