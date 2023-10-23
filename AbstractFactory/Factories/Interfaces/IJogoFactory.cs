using AbstractFactory.Entidades.Interfaces;

namespace DesignPatttern.AbstractFactory.Interfaces
{
    public interface IJogoFactory
    {
        IPersonagem CriarPersonagem();
        IArma CriarArma();
    }
}
