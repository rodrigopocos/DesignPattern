using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class AssentoCouroDecorator : CarroDecorator
    {
        public AssentoCouroDecorator(ICarro car) : base(car)
        {
        }

        public override string Description()
        {
            return $"{base.Description()}, Bancos de Couro";
        }

        public override double Cost()
        {
            return base.Cost() + 1000.0;
        }
    }
}
