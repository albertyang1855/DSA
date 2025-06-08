using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor.Domain.Enemy.Impl;
using Visitor.Visitor.Domain.Weapon.Interface;

namespace Visitor.Visitor.Domain.Weapon.Impl
{
    public abstract class Weapon : IWeapon
    {
        public int durability { get; set; }

        public string Name { get; set; }

        public abstract void VisitDragon(Dragon dragon);

        public abstract void VisitWitch(Witch witch);

        public abstract void VisitSoldier(Soldier witch);

        public void UpdateDurability(int durabilityChange)
        {
            this.durability += durabilityChange;
            this.durability = this.durability < 0 ? 0 : this.durability;

            Console.WriteLine(this.Name + " durability is deducted : " + this.durability + "\n");
        }
    }
}
