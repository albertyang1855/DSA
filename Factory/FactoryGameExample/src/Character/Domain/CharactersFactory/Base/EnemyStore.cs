using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Character.Domain.Characters;
using Factory.Character.Domain.Characters.Base;

namespace Factory.Character.Domain.CharactersFactory.Base
{
    public class EnemyStore : EnemyFactory
    {
        public override Enemy CreateEnemy(string enemyType)
        {
            if (enemyType == "Soldier") 
            {
                return new SoldierEnemy();
            }

            return null;
        }
    }
}
