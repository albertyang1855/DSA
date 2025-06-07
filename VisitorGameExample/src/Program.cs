using System.Drawing;
using Visitor.Visitor.Domain.Enemy.Impl;
using Visitor.Visitor.Domain.Enemy.Interface;
using Visitor.Visitor.Domain.Weapon.Impl;
using Visitor.Visitor.Domain.Weapon.Interface;

class Program
{
    static void Main(string[] args)
    {
        List<IEnemy> enemies = new List<IEnemy>
        {
            new Dragon(),
            new Witch(),
        };

        IWeapon dagger = new Dagger();

        foreach (var enemy in enemies)
        {
            enemy.Accept(dagger);
        }
    }
}
