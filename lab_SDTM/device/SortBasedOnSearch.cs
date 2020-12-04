using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    class SortBasedOnSearch : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); 

            Console.WriteLine("You might be interested in the following devices based on your search list: ");
        }
    }
}
