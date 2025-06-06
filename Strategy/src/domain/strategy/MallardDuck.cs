using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.domain.strategy.Base;
using Strategy.domain.strategy.Impl.ConcreteBehaviors;
using Strategy.domain.strategy.Interface;

namespace Strategy.domain.strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new QuackNormal();
        }

        public override void Display() => Console.WriteLine("I'm a real Mallard duck");
    }
}
