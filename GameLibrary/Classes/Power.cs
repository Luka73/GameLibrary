using GameLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public class Power : Item
    {
        public PowerType PowerType { get; set; }
        public int MinXp { get; set; }

        public Power()
        {
            
        }

        public Power(string name, int price, PowerType powerType, int minXp)
            : base(name, price)
        {
            this.PowerType = powerType;
            this.MinXp = minXp;
        }
    }
}
