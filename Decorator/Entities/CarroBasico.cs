using Decorator.Interfaces;

namespace Decorator.Entities
{
    public class CarroBasico : ICarro
    {
        public string Description()
        {
            return "Carro Básico";
        }

        public double Cost()
        {
            return 20000.0;
        }
    }
}
