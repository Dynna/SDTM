using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    class Tablet : DeviceItem
    {
        private string _name;
        private string _rating;

        public Tablet(string name, string rating, int numCopies)
        {
            this._name = name;
            this._rating = rating;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nTablet ------ ");
            Console.WriteLine(" Name: {0}", _name);
            Console.WriteLine(" Rating: {0}", _rating);
            Console.WriteLine(" # Sold copies: {0}", NumCopies);
        }
    }
}
