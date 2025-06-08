using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor.Domain.Enemy.Interface;
using Visitor.Visitor.Domain.Weapon.Interface;

namespace Visitor.Visitor.Domain.Enemy.Impl
{
    public class Soldier : Enemy
    {
        private const string SoldierName = "Soldier";

        public Soldier() 
        {
            this.Name = SoldierName;
            this.HP = 150; 
        }

        public override void Accept(IWeapon weapon)
        {
            weapon.VisitSoldier(this);
        }

    }
}
