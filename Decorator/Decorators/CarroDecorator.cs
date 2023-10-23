using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public abstract class CarroDecorator : ICarro
    {
        protected ICarro car;

        public CarroDecorator(ICarro car)
        {
            this.car = car;
        }

        public virtual string Description()
        {
            return car.Description();
        }

        public virtual double Cost()
        {
            return car.Cost();
        }
    }
}
