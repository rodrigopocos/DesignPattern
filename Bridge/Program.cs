using Bridge;

class Program
{
    static void Main(string[] args)
    {
        // Desenho na tela
        IDesenhoApi drawApiScreen = new DesenhoApiTela();

        Forma circleOnScreen = new Circulo(10, 50, 50, drawApiScreen);
        Forma rectangleOnScreen = new Retangulo(20, 30, 100, 100, drawApiScreen);

        circleOnScreen.Draw();
        rectangleOnScreen.Draw();

        // Impressão em uma impressora
        IDesenhoApi drawApiPrinter = new DesenhoApiImpressora();

        Forma circleOnPrinter = new Circulo(10, 50, 50, drawApiPrinter);
        Forma rectangleOnPrinter = new Retangulo(20, 30, 100, 100, drawApiPrinter);

        circleOnPrinter.Draw();
        rectangleOnPrinter.Draw();

        Console.ReadKey();
    }
}