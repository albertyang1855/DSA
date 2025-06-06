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
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void Display() => Console.WriteLine("I'm a rubber duck");
    }

}
