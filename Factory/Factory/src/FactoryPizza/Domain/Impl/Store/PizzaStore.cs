using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.FactoryPizza.Domain.Impl.Product;

namespace Factory.FactoryPizza.Domain.Impl.Store
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        // Factory Method
        protected abstract Pizza CreatePizza(string type);
    }

}
