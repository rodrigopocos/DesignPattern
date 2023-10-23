using Adapter.Adapters;
using Adapter;
using Adapter.Entitites.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Use o OldLogger com o adaptador
        IOldLogger oldLogger = new OldLogger();
        INewLogger oldLoggerAdapter = new OldLoggerAdapter(oldLogger);

        // Use o NewLogger diretamente
        INewLogger newLogger = new NewLogger();

        // Registre mensagens com ambos os loggers
        oldLoggerAdapter.LogMessage("Mensagem para OldLogger através do adaptador");
        newLogger.LogMessage("Mensagem para NewLogger diretamente");

        Console.ReadKey();
    }
}
