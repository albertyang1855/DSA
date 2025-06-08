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
        public string Name { get; set; }
        public abstract void Accept(IWeapon weapon);

        public void UpdateHP(int HPChange) 
        {
            this.HP += HPChange;
            this.HP = this.HP < 0 ? 0 : this.HP;

            Console.WriteLine(this.Name + " hp is deducted : " + this.HP + "\n");
        }
    }
}
