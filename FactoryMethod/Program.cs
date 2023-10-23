using FactoryMethod.Entities;

class Program
{
    static void Main(string[] args)
    {
        Logistica logisticaTerrestre = new LogisticaTerrestre();
        logisticaTerrestre.PlanoEntrega();  // Saída: "Preparando a entrega... Entrega por caminhão"

        Logistica logisticaMarinha = new LogisticaMarinha();
        logisticaMarinha.PlanoEntrega();   // Saída: "Preparando a entrega... Entrega por navio"

        Logistica logisticaAerea = new LogisticaAerea();
        logisticaAerea.PlanoEntrega();   // Saída: "Preparando a entrega... Entrega por avião"
    }
}
