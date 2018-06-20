using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new List<ItemList>
            {
                new ItemList("lettuce",10.5,50,"Leafy green"),
                new ItemList("cabbage",20,100,"Cruciferous"),
                new ItemList("pumpkin",30,30,"Marrow"),
                new ItemList("cauliflower",10,25,"Cruciferous"),
                new ItemList("zucchini",20.5,50,"Marrow"),
                new ItemList("yam",30,50,"Root"),
                new ItemList("spinach",10,100,"Leafy green"),
                new ItemList("broccoli",20.2,75,"Cruciferous"),
                new ItemList("Garlic",30,20,"Leafy green"),
                new ItemList("silverbeet",10,50,"Marrow")
            };

            List<ItemList> TypeLeafy;
            TypeLeafy = item.FindAll(x => x.ItemType.Contains("Leafy green"));
            Console.WriteLine("Leafy green type vegetables");
            foreach(var x in TypeLeafy)
            {
                Console.WriteLine(x.ItemName);
            }
            Console.WriteLine();

           
            List<ItemList> TypeCruci;
            TypeCruci = item.FindAll(x => x.ItemType.Contains("Cruciferous"));
            Console.WriteLine("Cruciferous type vegetables");
            foreach(var x in TypeCruci)
            {
                Console.WriteLine(x.ItemName);
            }
            Console.WriteLine();

            List<ItemList> TypeMarrow;
            TypeMarrow = item.FindAll(x => x.ItemType.Contains("Marrow"));
            Console.WriteLine("Marrow type vegetables");
            foreach(var x in TypeMarrow)
            {
                Console.WriteLine(x.ItemName);
            }
            Console.WriteLine();

            List<Price> amt = new List<Price> { };
           
                foreach(var x in item)
            {
                amt.Add(new Price(x.ItemQty, x.ItemPrice));
                
            }
            double sumPrice = 0;
            int sumQty = 0;
            foreach(var x in amt)
            {
                sumPrice = sumPrice + x.amt;
                sumQty = sumQty + x.Qty;
            }
            Console.WriteLine("Total price of inventory: " + sumPrice);
            Console.WriteLine("Total product of inventory: " + sumQty);
            Console.WriteLine("Average price of product in inventory:" + sumPrice / sumQty);
            Console.WriteLine();
            List<string> costlyProduct = new List<string> { };
            List<string> cheapProduct = new List<string> { };



            foreach (var x in item)
            {
                if (x.ItemPrice > 50)
                    costlyProduct.Add(x.ItemName);
                else
                    cheapProduct.Add(x.ItemName);
            }
            Console.WriteLine("List of costly product:");
            foreach (var x in costlyProduct)
                Console.WriteLine(x);
            Console.WriteLine();
            Console.WriteLine("List of cheap product:");
            foreach (var x in cheapProduct)
                Console.WriteLine(x);
            Console.Read();
        }
    }
}
