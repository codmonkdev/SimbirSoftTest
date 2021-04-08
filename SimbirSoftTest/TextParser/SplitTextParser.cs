using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftTest.TextParser
{
    public class SplitTextParser : ATextParser
    {

        public SplitTextParser(char[] delimetrs):base(delimetrs)
        {
        }
        public override IDictionary<string, int> parseText(string text)
        {
            string[] allWords = text.Split(delimetrs, StringSplitOptions.RemoveEmptyEntries);
            string[] notEmptyWords = allWords.Where(x => !string.IsNullOrEmpty(x) ).ToArray();
            string[] notEmptyUpperWords = notEmptyWords.Select(x => x.ToUpper()).ToArray();
            Dictionary<string, int> resDict = new Dictionary<string, int>();
            foreach (string str in notEmptyUpperWords)
            {
                if (resDict.ContainsKey(str)) {
                    resDict[str] = resDict[str]+ 1;
                } 
                else {
                    resDict.Add(str, 1);
                }
            }
            return resDict;
        }
    }
}
