using AbstractFactory.Entidades.Interfaces;

namespace AbstractFactory.Entidades
{
    public class Espada : IArma
    {
        public void Atacar() => Console.WriteLine("Ataque de Espada");
    }
}
