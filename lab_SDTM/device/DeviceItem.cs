using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    abstract class DeviceItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
    }
}
