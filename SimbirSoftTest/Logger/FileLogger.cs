using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimbirSoftTest.Logger
{
    /// <summary>
    /// Логгер в файл
    /// </summary>
    class FileLogger : ALogger
    {
        protected string filePathName;
        public FileLogger(int mask,string filePathName)
        {
            this.mask = mask;
            this.filePathName = filePathName;
            if (File.Exists(filePathName))
            {
                File.Delete(filePathName);
            }
            using (StreamWriter sw = File.CreateText(filePathName))
            {
                sw.WriteLine("==StartLog==");
            }
        }
        protected override void writeMessage(string msg)
        {
            using (StreamWriter sw = new StreamWriter(filePathName, true))
            {
                sw.WriteLine(msg);
            }
        }
    }
}
