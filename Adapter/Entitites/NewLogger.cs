using Adapter.Entitites;
using Adapter.Entitites.Interfaces;

namespace Adapter
{
    public class NewLogger : INewLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"[NewLogger] Logging: {message}");
        }
    }

}
