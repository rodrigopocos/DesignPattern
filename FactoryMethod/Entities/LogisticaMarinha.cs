using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities
{
    public class LogisticaMarinha : Logistica
    {
        public override ITransporte CriarTransporte()
        {
            return new Navio();
        }
    }
}
