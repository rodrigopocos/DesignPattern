using Adapter.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
    public class OldLoggerAdapter : INewLogger
    {
        private IOldLogger oldLogger;

        public OldLoggerAdapter(IOldLogger logger)
        {
            oldLogger = logger;
        }

        public void LogMessage(string message)
        {
            oldLogger.Log(message);
        }
    }

}
