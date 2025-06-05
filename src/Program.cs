using Strategy.domain.strategy.Base;
using Strategy.domain.strategy.Impl.ConcreteBehaviors;
using Strategy.domain.strategy;

class Program
{
    static void Main(string[] args)
    {
        Duck mallard = new MallardDuck();
        mallard.Display();
        mallard.PerformFly();
        mallard.PerformQuack();

        Console.WriteLine();

        Duck rubber = new RubberDuck();
        rubber.Display();
        rubber.PerformFly();
        rubber.PerformQuack();

        // Dynamically change behavior
        Console.WriteLine("\n-- Rubber duck learns to fly with rocket! --");
        rubber.SetFlyBehavior(new FlyWithWings());
        rubber.PerformFly();
    }
}
