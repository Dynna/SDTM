using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
