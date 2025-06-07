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

        public abstract void VisitDragon(Dragon dragon);

        public abstract void VisitWitch(Witch witch);

    }
}
