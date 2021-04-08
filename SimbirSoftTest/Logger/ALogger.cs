using System;
using System.Collections.Generic;
using System.Text;

namespace SimbirSoftTest.Logger
{
    /// <summary>
    /// Абстрактный класс логгера
    /// </summary>
    abstract public class ALogger
    {
        public static int INF = 1;
        public static int ERR = 3;
        public static int NOTICE = 5;
        public static int DEBUG = 7;
        protected int mask;

        protected ALogger next;

        public ALogger setNext(ALogger log)
        {
            next = log;
            return log;
        }

        public void message(String msg, int priority)
        {
            if (priority <= mask)
            {
                writeMessage(msg);
            }
            if (next != null)
            {
                next.message(msg, priority);
            }
        }

        abstract protected void writeMessage(String msg);

    }
}
