using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.device
{
    class SortBasedOnReviews : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.BasedOnReviewsSort(); not-implemented

            Console.WriteLine("You might also be interested in most rated devices: ");
        }
    }
}
