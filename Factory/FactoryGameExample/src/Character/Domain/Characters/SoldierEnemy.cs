using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Character.Domain.Characters.Base;

namespace Factory.Character.Domain.Characters
{
    public class SoldierEnemy : Enemy
    {
        private const int hpInit = 100;
        private const int attackInit = 100;
        private const int speedInit = 100;
        private const int specialPowerInit = 100;

        private const string DefaultName = "Enemy Soldier";

        public SoldierEnemy() 
        {
            this.name = DefaultName;
        }

        public override void InitHp(int? customHpInit = null)
        {
            this.hp = customHpInit.HasValue ? customHpInit.Value : hpInit;
        }

        public override void InitAttack(int? customAttackInit = null)
        {
            this.attack = customAttackInit.HasValue ? customAttackInit.Value : attackInit;
        }
        public override void InitSpeed(int? customSpeedInit = null)
        {
            this.speed = customSpeedInit.HasValue ? customSpeedInit.Value : speedInit;
        }

        public override void InitSpecialPower(int? customSpecialPowerInit = null)
        {
            this.specialPower = customSpecialPowerInit.HasValue ? customSpecialPowerInit.Value : specialPowerInit;
        }
    }
}
