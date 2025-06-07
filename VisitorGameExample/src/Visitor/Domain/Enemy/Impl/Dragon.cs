using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor.Domain.Weapon.Impl;
using Visitor.Visitor.Domain.Weapon.Interface;

namespace Visitor.Visitor.Domain.Enemy.Impl
{
    public class Dragon : Enemy
    {
        public Dragon() { this.HP = 300; }
        public override void Accept(IWeapon weapon)
        {
            weapon.VisitDragon(this);
        }
    }
}
