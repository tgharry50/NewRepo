using DecoratorExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Decorators
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected ICoffee _coffee;
        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public virtual double Cost()
        {
            return _coffee.Cost();
        }

        public virtual string GetDesc()
        {
            return _coffee.GetDesc();
        }
    }
}
