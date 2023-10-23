using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities
{
    public abstract class Logistica
    {
        public abstract ITransporte CriarTransporte();

        public void PlanoEntrega()
        {
            ITransporte transport = CriarTransporte();
            Console.WriteLine("Preparando a entrega...");
            transport.Entregar();
        }
    }
}
