using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryPizza.Domain.Impl.Product
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Baking pizza");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }

        public virtual void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}
