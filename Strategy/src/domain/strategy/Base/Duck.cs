using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.domain.strategy.Interface;

namespace Strategy.domain.strategy.Base
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck() { }

        public void PerformFly() => flyBehavior.Fly();
        public void PerformQuack() => quackBehavior.Quack();

        public void SetFlyBehavior(IFlyBehavior fb) => flyBehavior = fb;
        public void SetQuackBehavior(IQuackBehavior qb) => quackBehavior = qb;

        public abstract void Display();

        public void Swim() => Console.WriteLine("All ducks float, even decoys!");
    }

}
