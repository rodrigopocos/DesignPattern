using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class TetoSolarDecorator : CarroDecorator
    {
        public TetoSolarDecorator(ICarro car) : base(car)
        {
        }

        public override string Description()
        {
            return $"{base.Description()}, Teto Solar";
        }

        public override double Cost()
        {
            return base.Cost() + 1500.0;
        }
    }

}
