using AbstractFactory.Entidades;
using AbstractFactory.Entidades.Interfaces;

namespace DesignPatttern.AbstractFactory.Interfaces
{
    public class JogoFantasiaFactory : IJogoFactory
    {
        public IPersonagem CriarPersonagem() => new Mago();

        public IArma CriarArma() => new Cajado();
    }
}
