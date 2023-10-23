using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities
{
    public class LogisticaAerea : Logistica
    {
        public override ITransporte CriarTransporte()
        {
            return new Aviao();
        }
    }
}
