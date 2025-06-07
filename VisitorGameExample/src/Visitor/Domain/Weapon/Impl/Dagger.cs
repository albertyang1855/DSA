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
        public Dagger() { this.durability = 70; }
        public override void VisitDragon(Dragon dragon)
        {
            this.durability -= 3;
            
            dragon.HP -= 30;

            Console.WriteLine("dragon hp is deducted : " + dragon.HP + "\n");
            Console.WriteLine("your daggar durability is deducted : " + this.durability + "\n");
        }

        public override void VisitWitch(Witch witch)
        {
            this.durability -= 5;

            witch.HP -= 50;

            Console.WriteLine("witch hp is deducted : " + witch.HP + "\n");
            Console.WriteLine("your daggar durability is deducted : " + this.durability + "\n");
        }
    }
}
