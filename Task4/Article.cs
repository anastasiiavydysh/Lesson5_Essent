using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Article
    {
        //• Назва товару;
        private string itemName;
        //• назва магазину, в якому продається товар;
        private string shopName;
        //• вартість товару в гривнях.
        private decimal price;

        public string ItemName { get; set; }


        public Article(string itemName, string shopName, decimal price)
        {
            this.itemName = itemName.ToLower();
            this.shopName = shopName.ToLower();
            this.price = price;
            ItemName = itemName.ToLower();
        }

        public void Display()
        {
            Console.WriteLine("Item name: "+ itemName + ", shop name: "+ shopName + ", price: "+ price);
        }
    }
}
