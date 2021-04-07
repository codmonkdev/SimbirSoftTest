using SimbirSoftTest.Logger;
using System;
using System.IO;

namespace SimbirSoftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ALogger Logger = LogBuilder.buildLog(ALogger.DEBUG);

            Logger.message("Hello World!",ALogger.DEBUG);
        }
    }
}
