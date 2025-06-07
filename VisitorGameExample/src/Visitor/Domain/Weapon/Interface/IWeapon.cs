using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor.Domain.Enemy.Impl;

namespace Visitor.Visitor.Domain.Weapon.Interface
{
    public interface IWeapon
    {
        public void VisitDragon(Dragon dragon);
        public void VisitWitch(Witch dragon);
    }
}
