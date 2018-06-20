using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3Q1
{
    class Price
    {
        public int Qty;
        public double price;
        public double amt;

        public Price(int q,double p)
        {
            this.Qty = q;
            this.price = p;
            this.amt = p * q;
        }
        
       

        public override string ToString()
        {
            return string.Format("IQUANTYTY: " + Qty + "  IPRICE: " + price + "  IAMT: " + amt);
        }
    }
}
