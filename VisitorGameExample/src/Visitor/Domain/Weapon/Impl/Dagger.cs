using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Visitor.Domain.Enemy.Impl;
using Visitor.Visitor.Domain.Weapon.Interface;

namespace Visitor.Visitor.Domain.Weapon.Impl
{
    public class Dagger : Weapon
    {
        private const string DaggerName = "Dagger";

        public Dagger() 
        { 
            this.Name = DaggerName;
            this.durability = 70; 
        }


        public override void VisitDragon(Dragon dragon)
        {
            dragon.UpdateHP(-30);
            UpdateDurability(-3);
        }

        public override void VisitWitch(Witch witch)
        {
            witch.UpdateHP(-50);
            UpdateDurability(-5);
        }

        public override void VisitSoldier(Soldier soldier) 
        {
            soldier.UpdateHP(-60);
            UpdateDurability(-3);
        }

    }
}
