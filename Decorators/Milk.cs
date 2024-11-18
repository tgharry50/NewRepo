using DecoratorExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Decorators
{
    public class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee) : base(coffee)
        {
        }
        public override string GetDesc()
        {
            return $"{base.GetDesc()}, z mlekiem";
        }
        public override double Cost()
        {
            return base.Cost() + 2.3;
        }
    }
}
