using HtmlAgilityPack;
using System;
using System.Text;


namespace SimbirSoftTest.TextDownloader
{
    /// <summary>
    /// Класс для загрузки текста с url при помощи библиотеки HtmlAgilityPack
    /// Реализует интерфейс ITextDownloader
    /// </summary>
    public class TextDownloaderAgility : ITextDownloader
    {
        public string downloadText(string url)
        {
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(wc.DownloadString(url));
                var htmlNodes = document.DocumentNode.SelectNodes("//body");
                var sb = new StringBuilder();
                foreach (var node in htmlNodes)
                {
                    if (!String.IsNullOrEmpty(node.InnerText.Trim()))
                        sb.Append(node.InnerText);
                }
                return sb.ToString();
            }


            //WebClient web = new WebClient();
            //System.IO.Stream stream = web.OpenRead(url);
            //using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            //{
            //    String text = reader.ReadToEnd();
            //    Logger.message(text, ALogger.DEBUG);
            //}


            //WebClient wc = new System.Net.WebClient();
            //byte[] raw = wc.DownloadData(url);

            //string webData = System.Text.Encoding.UTF8.GetString(raw);
            //Logger.message(webData, ALogger.DEBUG);

            //var webRequest = WebRequest.Create(url);

            //using (var response = webRequest.GetResponse())
            //using (var content = response.GetResponseStream())
            //usinLogger.message(strContent, ALogger.DEBUG);g (var reader = new StreamReader(content))
            //{
            //    var strContent = reader.ReadToEnd();

            //}


        }
    }
}
