using design_patterns.client;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device_factory
{
    abstract class Stock
    {
        private string _model;
        private double _price;
        private List<IClient> _clients = new List<IClient>();

        public Stock(string model, double price)
        {
            this._model = model;
            this._price = price;
        }

        public void Attach(IClient client)
        {
            _clients.Add(client);
        }

        public void Dettach(IClient client)
        {
            _clients.Remove(client);
        }

        public void Notify()
        {
            foreach(IClient client in _clients)
            {
                client.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {
            get { return _price; }
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Model
        {
            get { return _model; }
        }

    }
}
