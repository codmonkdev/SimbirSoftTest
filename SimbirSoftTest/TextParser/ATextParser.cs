using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftTest.TextParser
{
    public abstract class ATextParser
    {
       protected char[] delimetrs;
       public ATextParser(char[] delimetrs)
        {
            this.delimetrs = delimetrs;
        }

        abstract public IDictionary<String, int> parseText(String text);
    }
}
