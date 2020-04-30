using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public class Monster : LivingEntity
    {
        public int Ap { get; set; }
        public int Rxp { get; set; }
        public Player Target { get; set; }

        public Monster()
        {

        }

        public Monster(string name, int hp, int ap, int rxp)
            : base(name, hp)
        {
            Ap = ap;
            Rxp = rxp;
        }

        public override void Attack()
        {
            int random = Dice.GetInstance().Next(0, Ap);
            Target.ReceiveDamage(random);

        }
    }
}
