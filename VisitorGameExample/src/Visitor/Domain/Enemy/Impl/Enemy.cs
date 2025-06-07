using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor.Domain.Enemy.Interface;
using Visitor.Visitor.Domain.Weapon.Interface;

namespace Visitor.Visitor.Domain.Enemy.Impl
{
    public abstract class Enemy : IEnemy
    {
        public int HP { get; set; }
        public abstract void Accept(IWeapon weapon);

    }
}
