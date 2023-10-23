using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities
{
    public class Aviao : ITransporte
    {
        public void Entregar()
        {
            Console.WriteLine("Entrega por avião");
        }
    }
}
