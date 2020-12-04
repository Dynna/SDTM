using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    class SortedDevices
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string model)
        {
            _list.Add(model);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            foreach (string model in _list)
            {
                Console.WriteLine(" " + model);
            }
            Console.WriteLine();
        }
    }
}
