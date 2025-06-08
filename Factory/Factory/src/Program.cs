using Factory.FactoryPizza.Domain.Impl.Product;
using Factory.FactoryPizza.Domain.Impl.Store;

class Program
{
    static void Main()
    {
        PizzaStore nyStore = new NYPizzaStore();

        Pizza pizza = nyStore.OrderPizza("cheese");

        Console.WriteLine($"You ordered a {pizza.Name}");
    }
}
