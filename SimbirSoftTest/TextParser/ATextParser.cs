using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftTest.TextParser
{
    /// <summary>
    /// Абстрактный класс для разбора текста на слова
    /// </summary>
    public abstract class ATextParser
    {
       /// <summary>
       /// Массил разделителей
       /// </summary>
       protected char[] delimetrs;
       
        /// <summary>
       /// Конструктор
       /// </summary>
       /// <param name="delimetrs">Набор разделителей</param>
       public ATextParser(char[] delimetrs)
        {
            this.delimetrs = delimetrs;
        }

        /// <summary>
        /// Абстрактный метод для разбора текста
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        abstract public IDictionary<String, int> parseText(String text);
    }
}
