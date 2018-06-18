using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1Q1
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

            Console.WriteLine("Total no of item in inventory: " + item.Count());
            Console.WriteLine();

            item.Add(new ItemList("Potato",10,50,"Root"));

            foreach (var itm in item)
                Console.WriteLine(itm);

            Console.WriteLine();
            Console.WriteLine("Items of type Leafy green:");
            Console.WriteLine();
            List<ItemList> gli;
            gli=item.FindAll(x=>x.ItemType.Contains("Leafy green"));
            foreach (var itm in gli)
                Console.WriteLine(itm);

            item.Remove(item.Find(x => x.ItemName.Contains("Garlic")));
            Console.WriteLine("Total no of item in inventory: " + item.Count());
            Console.WriteLine();
            
            int ind=item.FindIndex(x=> x.ItemName.Contains("cabbage"));
            item[ind].ItemQty = item[ind].ItemQty + 50;
            foreach (var itm in item)
                Console.WriteLine(itm);

            Console.WriteLine();
            double lec_price;
            ind= item.FindIndex(x => x.ItemName.Contains("lettuce"));
            lec_price = item[ind].ItemPrice;
            double zuc_price;
            ind = item.FindIndex(x => x.ItemName.Contains("zucchini"));
            zuc_price = item[ind].ItemPrice;
            double bro_price;
            ind = item.FindIndex(x => x.ItemName.Contains("broccoli"));
            bro_price = item[ind].ItemPrice;

            double total = (1 * lec_price) + (2 * zuc_price) + (1 * bro_price);
            int final_amt =(int) Math.Round(total);
            Console.WriteLine("Price of 1kg lecttuce, 2kg zucchini and 1kg broccoli: "+final_amt);

            Console.Read();
        }
    }
}
