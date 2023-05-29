using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPMain
{
    internal class BetterLogService
    {
        private readonly ILogger _logger;
        public BetterLogService(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
