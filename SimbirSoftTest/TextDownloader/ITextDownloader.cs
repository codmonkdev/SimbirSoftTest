using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftTest.TextDownloader
{
    public interface ITextDownloader
    {
        public string downloadText(string url);
    }
}
