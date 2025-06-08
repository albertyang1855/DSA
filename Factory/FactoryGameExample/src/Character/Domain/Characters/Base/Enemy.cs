using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Character.Domain.Characters.Base
{
    public abstract class Enemy
    {
        public string name { get; set; }

        public int hp { get; set; }

        public int speed { get; set; }

        public int attack { get; set; }

        public int specialPower { get; set; }

        public abstract void InitHp(int? hp = null);

        public abstract void InitSpeed(int? speed = null);

        public abstract void InitAttack(int? attack = null);

        public abstract void InitSpecialPower(int? specialPower = null);

        public void ReportStatus() 
        {
            Console.WriteLine($"Unit Type: {this.name}" + "\n");
            Console.WriteLine($"Unit hp: {this.hp}" + "\n");
            Console.WriteLine($"Unit speed: {this.speed}" + "\n");
            Console.WriteLine($"Unit attack: {this.attack}" + "\n");
            Console.WriteLine($"Unit specialPower: {this.specialPower}" + "\n");
        }
    }
}
