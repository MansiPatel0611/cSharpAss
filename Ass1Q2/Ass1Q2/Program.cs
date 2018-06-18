using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            var data =new List<string> {"Boat","horse","cat","river","cupboard" };

            Console.WriteLine("plural of all words:");
            foreach (var x in data)
            {
                Console.WriteLine(x + "s");
            }

            int ind = data.IndexOf("horse");
            data[ind] = "foal";
            Console.WriteLine("afer adding synonym of horse as foal:");
            foreach (var x in data)
            {
                Console.WriteLine(x);
            }

            data.Add("peanuts");
            Console.WriteLine("length of array:" + data.Count);

            for(int i=0;i<data.Count;i++)
            {
                if (data[i].Length == 7)
                    Console.WriteLine(data[i]);
            }
            Console.WriteLine("word at 3rd position: " + data[2]);
            Console.WriteLine("data in accending order:");
            data.Sort();
            foreach (var x in data)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("data in reverse order:");
            data.Reverse();
            foreach (var x in data)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
