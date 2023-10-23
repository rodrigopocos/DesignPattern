using Adapter.Entitites;
using Adapter.Entitites.Interfaces;

namespace Adapter
{
    public class OldLogger : IOldLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[OldLogger] Logging: {message}");
        }
    }
}
