using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_1
{
     class Furniture : IComparable<Furniture>
     {
        public string name { get; set; }
        public int price { get; set; }
        public int dimensions { get; set; }

        public Furniture(string name,int price,int dimensions)
        {
            this.name = name;
            this.price = price;
            this.dimensions = dimensions;


        }
        public int CompareTo(Furniture obj)
        {
            if (this.price < obj.price)
            {
                return 1;
            }
            if (this.price > obj.price)
                return -1;
            else
                return 0;

        }
        public override string ToString()
        {
            return String.Format("\tНазва: {0}\tПрайс: {1}\tГабарити:{2}", this.name, this.price, this.dimensions);

        }

        


    }
}
