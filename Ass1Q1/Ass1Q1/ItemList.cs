using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1Q1
{
    public class ItemList
    {
        public string ItemName { get; protected set; }
        public double ItemPrice { get; protected set; }
        public int ItemQty { get; internal set; }
        public string ItemType { get; private set; }

        public ItemList(string Iname, double Iprice,int Iqty, string Itype)
        {
            this.ItemName = Iname;
            this.ItemPrice = Iprice;
            this.ItemQty = Iqty;
            this.ItemType = Itype;
        }
        public void addnewitem(string Iname, double Iprice, int Iqty, string Itype)
        {
            this.ItemName = Iname;
            this.ItemPrice = Iprice;
            this.ItemQty = Iqty;
            this.ItemType = Itype;
        }
        public override string ToString()
        {
            return string.Format("INAME: " + ItemName  + "\t"+"IPRICE: " + ItemPrice + "\t" + "IQUANTYTY: " + ItemQty + "\t" + "ITYPE: " + ItemType);
        }
    }
}
