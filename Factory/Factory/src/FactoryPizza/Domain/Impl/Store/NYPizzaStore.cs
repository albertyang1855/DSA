using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.FactoryPizza.Domain.Impl;
using Factory.FactoryPizza.Domain.Impl.Product;

namespace Factory.FactoryPizza.Domain.Impl.Store
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }

}
