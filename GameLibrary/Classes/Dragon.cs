using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public class Dragon : Monster
    {
        public int Rgp { get; set; }
        public static Random random = new Random();

        public Dragon()
        {
            Rgp = random.Next(1000, 10000);
        }

        public Dragon(string name, int hp, int ap, int rxp)
            : base(name, hp, ap, rxp)
        {
            Rgp = random.Next(1000, 10000);
        }
    }
}
