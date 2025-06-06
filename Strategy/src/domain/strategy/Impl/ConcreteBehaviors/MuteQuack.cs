using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.domain.strategy.Interface;

namespace Strategy.domain.strategy.Impl.ConcreteBehaviors
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack() => Console.WriteLine("<< Silence >>");
    }
}
