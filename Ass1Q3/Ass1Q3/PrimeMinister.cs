using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1Q3
{
    class PrimeMinister
    {
        public string MinsterName { get; private set; }
        public int ElectYear { get; private set; }
        
        public PrimeMinister(string pname,int year )
        {
            this.MinsterName = pname;
            this.ElectYear = year;
        }
        public override string ToString()
        {
            return string.Format("Name: "+MinsterName+"\n"+"year: "+ElectYear);
        }
    }
}
