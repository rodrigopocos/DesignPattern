using AbstractFactory.Entidades.Interfaces;

namespace AbstractFactory.Entidades
{
    public class Guerreiro : IPersonagem
    {
        public void Exibir() => Console.WriteLine("Personagem Guerreiro criado");
    }
}
