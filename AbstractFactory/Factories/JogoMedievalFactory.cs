using AbstractFactory.Entidades;
using AbstractFactory.Entidades.Interfaces;
using DesignPatttern.AbstractFactory.Interfaces;

namespace DesignPatttern.AbstractFactory.Factories
{
    public class JogoMedievalFactory : IJogoFactory
    {
        public IPersonagem CriarPersonagem() => new Guerreiro();

        public IArma CriarArma() => new Espada();
    }
}
