using GameLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Classes
{
    public class Player : LivingEntity
    {
        #region Properties
        public int HpMax { get; set; }
        public int Xp { get; set; } = 0;
        public int Gp { get; set; } = 0;
        public bool Protect { get; set; } = false;
        public Monster Enemy { get; set; }
        public List<Power> MyPowers { get; set; } = new List<Power>();
        public Weapon MyWeapon { get; set; } = new Weapon("Wood Stick", 0, 5, 15);
        #endregion

        #region Constructors
        public Player()
        {

        }

        public Player(string name, int hp)
            : base(name, hp)
        {
            HpMax = hp;
        }
        #endregion

        #region Methods
        public void Heal()
        {
            Hp = HpMax;
        }

        public void Hide()
        {
            Enemy = null;
        }

        public void Sprinkle()
        {
            if(Enemy is Dragon)
            {
                Gp += ((Dragon)Enemy).Rgp;
                Hide();
            }
        }

        public void AddPower(Power newPower)
        {
            MyPowers.Add(newPower);
        }

        public Power GetPower(PowerType powerType)
        {
            foreach (Power power in MyPowers)
            {
                if (power.PowerType == powerType)
                {
                    return power;
                }
            }
            return null;
        }

        public void ApplyPower(PowerType powerType)
        {
            Power power = GetPower(powerType);

            if (power == null)
            {
                Console.WriteLine("You don't have this power");
            }
            else
            {
                if (Xp >= power.MinXp)
                {
                    if (power.PowerType == PowerType.Healing)
                    {
                        Heal();
                    }
                    else if (power.PowerType == PowerType.Invisible)
                    {
                        Hide();
                    }
                    else if (power.PowerType == PowerType.Protect)
                    {
                        Protect = true;
                    }
                    else if (power.PowerType == PowerType.Sleepy)
                    {
                        Sprinkle();
                    }

                    MyPowers.Remove(power);
                }
            }
        }

        public void UpdateWeapon(Weapon aWeapon)
        {
            if (MyWeapon.MaxDamage < aWeapon.MaxDamage)
            {
                MyWeapon = aWeapon;
            }
        }

        public void BuyItem(Item newItem)
        {
            if (Gp >= newItem.Price)
            {
                Gp -= newItem.Price;

                if (newItem is Weapon)
                {
                    UpdateWeapon((Weapon)newItem);
                }
                else if (newItem is Power)
                {
                    AddPower((Power)newItem);
                }
            }
        }

        public override void ReceiveDamage(int damage)
        {
            Hp = (Protect) ? Hp - damage / 2 : Hp - damage;
            //Se damage for ímpar, ele vai ignorar os decimais
        }

        public override void Attack()
        {
            Random random = new Random();
            int damage = random.Next(MyWeapon.MinDamage, MyWeapon.MaxDamage);
            Enemy.ReceiveDamage(damage);
            if (Enemy.IsDead())
            {
                Xp += Enemy.Rxp;

                if (Enemy is Dragon)
                {
                    Gp += ((Dragon)Enemy).Rxp;
                }
            }
        }
        #endregion
    }
}
