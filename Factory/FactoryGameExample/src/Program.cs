
using Factory.Character.Domain.CharactersFactory.Base;

class Program
{
    static void Main()
    {
        var enemyStore = new EnemyStore();

        var soldierEnemy = enemyStore.OrderEnemy("Soldier");

        soldierEnemy.ReportStatus();
    }
}
