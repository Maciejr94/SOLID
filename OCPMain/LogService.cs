using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPMain
{
    internal class LogService
    {
        private readonly LogType _logType;
        public LogService(LogType logType)
        {
            _logType = logType;
        }

        public virtual void Log(string message)
        {
            switch (_logType)
            {
                case LogType.Console:
                    break;
                case LogType.File:
                    break;
                case LogType.Database:
                    break;
                default:
                    break;
            }
            
        }

    }
}
