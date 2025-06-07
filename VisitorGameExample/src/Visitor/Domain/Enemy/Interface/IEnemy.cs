using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor.Domain.Weapon.Interface;
using Visitor.Visitor.Domain.Weapon.Impl;

namespace Visitor.Visitor.Domain.Enemy.Interface
{
    public interface IEnemy
    {
        void Accept(IWeapon weapon);
    }
}
