﻿using DecoratorExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Decorators
{
    public class Sugar : CoffeeDecorator
    {
        public Sugar(ICoffee coffee) : base(coffee)
        {
        }
        public override string GetDesc()
        {
            return $"{base.GetDesc()}, z cukrem";
        }
        public override double Cost()
        {
            return base.Cost() + 3.0;
        }
    }
}
