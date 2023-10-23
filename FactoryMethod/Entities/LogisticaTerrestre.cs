using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities
{
    public class LogisticaTerrestre : Logistica
    {
        public override ITransporte CriarTransporte()
        {
            return new Caminhao();
        }
    }
}
