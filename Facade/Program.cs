using Facade.Facades;

class Program
{
    static void Main(string[] args)
    {
        AudioSystemFacade audioFacade = new AudioSystemFacade();

        // Inicie a música usando a fachada
        audioFacade.StartMusic();

        // Pare a música usando a fachada
        audioFacade.StopMusic();

        Console.ReadKey();
    }
}