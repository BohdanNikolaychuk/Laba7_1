using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_1
{
    class CompInv<T> : IComparer<T>
        where T : Furniture
    {
        public int Compare(T x, T y)
        {
            if (x.price < y.price)
                return 1;
            else if (x.price > y.price)
                return -1;

            else if (x.dimensions < y.dimensions )
                return 1;

            else if (x.dimensions > y.dimensions)
                return -1;

            else
                return 0;
        }


    }
}
