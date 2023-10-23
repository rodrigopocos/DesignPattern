using AbstractFactory.Entidades.Interfaces;

namespace AbstractFactory.Entidades
{
    public class Cajado : IArma
    {
        public void Atacar() => Console.WriteLine("Ataque de Cajado");
    }
}
