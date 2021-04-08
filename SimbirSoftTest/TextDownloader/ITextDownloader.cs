using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirSoftTest.TextDownloader
{
    /// <summary>
    /// Интерфейс для загрузки текста страницы с URL
    /// </summary>
    public interface ITextDownloader
    {
        public string downloadText(string url);
    }
}
