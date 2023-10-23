using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities
{
    public class Caminhao : ITransporte
    {
        public void Entregar()
        {
            Console.WriteLine("Entrega por caminhão");
        }
    }
}
