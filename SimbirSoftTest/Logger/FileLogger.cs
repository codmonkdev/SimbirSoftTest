using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimbirSoftTest.Logger
{
    class FileLogger : ALogger
    {
        protected string filePathName;
        public FileLogger(int mask,string filePathName)
        {
            this.mask = mask;
            this.filePathName = filePathName;
        }
        protected override void writeMessage(string msg)
        {
            if (File.Exists(filePathName))
            {
                File.Delete(filePathName);
            }
            using (StreamWriter sw = File.CreateText(filePathName))
            {
                sw.WriteLine(msg);
            }
        }
    }
}
