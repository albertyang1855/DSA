using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.domain.strategy.Interface;

namespace Strategy.domain.strategy.Impl.ConcreteBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly() => Console.WriteLine("I'm flying!");
    }
}
