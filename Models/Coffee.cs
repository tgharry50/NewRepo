using DecoratorExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample.Models
{
    public class Coffee : ICoffee
    {
        public double Cost()
        {
            return 4.0;
        }

        public string GetDesc()
        {
            return "Kawa";
        }
    }
}
