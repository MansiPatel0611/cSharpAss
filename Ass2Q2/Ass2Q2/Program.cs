using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0.06f;
            float y = 5.94f;
            Console.WriteLine("{0}", x + y);
            Console.WriteLine("{0} + {1} = {2} == 6 is {3}",x,y,x+y,x+y==6);
            if (x > y)
                Console.WriteLine("x is greater");
            else
                Console.WriteLine("y is greater");
            Console.Read();
        }
    }
}
