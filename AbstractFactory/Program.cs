using AbstractFactory.Entidades.Interfaces;
using DesignPatttern.AbstractFactory.Factories;
using DesignPatttern.AbstractFactory.Interfaces;

class Program
{

    static void Main(string[] args)
    {
        // Crie uma fábrica de jogos de fantasia
        IJogoFactory fantasiaFactory = new JogoFantasiaFactory();
        IPersonagem personagemFantasia = fantasiaFactory.CriarPersonagem();
        IArma armaFantasia = fantasiaFactory.CriarArma();

        personagemFantasia.Exibir(); // Saída: "Personagem Mago criado"
        armaFantasia.Atacar();       // Saída: "Ataque de Cajado"

        // Crie uma fábrica de jogos medievais
        IJogoFactory medievalFactory = new JogoMedievalFactory();
        IPersonagem personagemMedieval = medievalFactory.CriarPersonagem();
        IArma armaMedieval = medievalFactory.CriarArma();

        personagemMedieval.Exibir(); // Saída: "Personagem Guerreiro criado"
        armaMedieval.Atacar();       // Saída: "Ataque de Espada"
    }
}
