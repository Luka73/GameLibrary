using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public class Weapon : Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon()
        {

        }

        public Weapon(string name, int price, int minDamage, int maxDamage)
            : base(name, price)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
