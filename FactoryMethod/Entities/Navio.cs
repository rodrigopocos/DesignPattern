using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities
{
    public class Navio : ITransporte
    {
        public void Entregar()
        {
            Console.WriteLine("Entrega por navio");
        }
    }
}
