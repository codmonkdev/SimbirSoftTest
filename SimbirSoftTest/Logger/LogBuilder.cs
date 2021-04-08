using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimbirSoftTest.Logger
{
    /// <summary>
    /// Построитель логгера
    /// </summary>
    public class LogBuilder
    {
        static public ALogger buildLog()
        {
            ALogger aLogger, aLogger1;
            aLogger = new ConsoleLogger(ALogger.INF);
            aLogger1 = new FileLogger(ALogger.DEBUG, Path.Combine(AppContext.BaseDirectory, "Log.log"));
            aLogger.setNext(aLogger1);
            return aLogger;

        }
    }
}
