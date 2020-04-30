using GameLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public abstract class LivingEntity : ILivingEntity
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        protected LivingEntity()
        {

        }

        protected LivingEntity(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }

        public bool IsDead()
        {
            return Hp <= 0;
        }

        public virtual void ReceiveDamage(int damage)
        {
            Hp -= damage;
        }

        public virtual void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
