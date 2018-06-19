using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<string>
            {
                "Tomato",
                "Potato",
                "ToMato",
                "Potato",
                "Red Tomato",
                "Tomato Catchup",
                "Grapes",
                "grapes",
                "potato"
            };

            Console.WriteLine();
            Console.WriteLine("Types of string 'tomato':");
            int count = 0;
           
           for(int i=0;i<data.Count;i++)
            {
                string x = data[i];
                
                if (x.Contains("tomato",StringComparison.InvariantCultureIgnoreCase)) 
                    count++;
            }
            Console.WriteLine(count);
            Console.WriteLine();
            Console.WriteLine("index of 'Potato'");
            for(int i=0;i<data.Count;i++)
            {
                if (data[i].Contains("Potato"))
                    Console.WriteLine(i);
            }
            Console.Read();
        }


       

    }

}
