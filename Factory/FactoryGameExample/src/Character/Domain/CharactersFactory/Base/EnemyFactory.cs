using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Character.Domain.Characters.Base;

namespace Factory.Character.Domain.CharactersFactory.Base
{
    public abstract class EnemyFactory
    {
        public abstract Enemy CreateEnemy(string enemyType);

        public Enemy OrderEnemy(string enemyType)
        {
            Enemy enemy = CreateEnemy(enemyType);
            enemy.InitAttack();
            enemy.InitHp();
            enemy.InitSpeed();
            enemy.InitSpecialPower();

            return enemy;
        }
    }
}
