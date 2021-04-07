using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoftTest.Logger
{
    public class ConsoleLogger : ALogger
    {
        public ConsoleLogger(int mask)
        {
            this.mask = mask;
        }
        protected override void writeMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
