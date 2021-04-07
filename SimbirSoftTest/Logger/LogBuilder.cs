using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimbirSoftTest.Logger
{
    public class LogBuilder
    {
        static public ALogger buildLog(int mask)
        {
            ALogger aLogger, aLogger1;
            aLogger = new ConsoleLogger(mask);
            aLogger1 = new FileLogger(mask,Path.Combine(AppContext.BaseDirectory, "Log.log"));
            aLogger.setNext(aLogger1);
            return aLogger;

        }
    }
}
