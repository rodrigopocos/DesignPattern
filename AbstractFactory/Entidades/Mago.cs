using AbstractFactory.Entidades.Interfaces;

namespace AbstractFactory.Entidades
{
    public class Mago : IPersonagem
    {
        public void Exibir() => Console.WriteLine("Personagem Mago criado");
    }
}
