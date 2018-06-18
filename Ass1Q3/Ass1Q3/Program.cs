using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            var primemister = new Dictionary<string, PrimeMinister>
            {
                {"AB",new PrimeMinister("Atal Bihari Vajpayee",1998) },
                {"NM",new PrimeMinister("Narendra Modi",2014) },
                {"MS",new PrimeMinister("Manmohan Singh",2004) }
            };

            foreach (var x in primemister)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Prime Minister of 2004: ");

            var p = primemister.FirstOrDefault(y => y.Value.ElectYear == 2004).Key;
            Console.WriteLine(primemister[p]);
            Console.WriteLine();
            primemister.Add("nm", new PrimeMinister("Narendra Modi", 2018));
            foreach (var x in primemister)
            {
                Console.WriteLine(x);
            }


            
            Console.WriteLine();
            Console.WriteLine("sorted list:");
            var mewprime= primemister.OrderBy(x => x.Value.ElectYear);
            foreach (var x in mewprime)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
