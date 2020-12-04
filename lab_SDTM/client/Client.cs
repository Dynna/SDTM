using design_patterns.client;
using design_patterns.device_factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab1_SDTM
{
    class Client : IClient
    {
        private ISmartphone smartphone;
        private ITablet tablet;
        private string _name;
        private Stock _stock;

        public Client(IDeviceFactory factory, string series)
        {
            smartphone = factory.ManufactureSmartphone(series);
            tablet = factory.ManufactureTablet(series);
        }

        public Client(string name)
        {
            this._name = name;
        }

        public string GetManufacturedSmartphoneName()
        {
            return smartphone.Name();
        }

        public string GetManufacturedTabletName()
        {
            return tablet.Name();
        }

        public string GetRequest()
        {
            return "Your phone is ready to deliver";
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notification for {0}, there is a new {1} with hot price {2:C}", _name, stock.Model, stock.Price);
        }

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
