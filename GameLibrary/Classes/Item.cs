using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Item()
        {

        }

        public Item(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
