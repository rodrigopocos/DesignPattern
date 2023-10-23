using Flyweight;

class Program
{
    static void Main(string[] args)
    {
        FontFactory fontFactory = new FontFactory();

        // Crie várias instâncias de fontes compartilhadas
        Font font1 = fontFactory.GetFont("Arial", 12);
        Font font2 = fontFactory.GetFont("Arial", 12);
        Font font3 = fontFactory.GetFont("Times New Roman", 16);

        // Renderize texto usando essas fontes
        font1.Render("Texto em Arial 12");
        font2.Render("Mais texto em Arial 12");
        font3.Render("Texto em Times New Roman 16");

        Console.ReadKey();
    }
}
