using HtmlAgilityPack;
using SimbirSoftTest.Logger;
using SimbirSoftTest.TextDownloader;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SimbirSoftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ALogger Logger = LogBuilder.buildLog(ALogger.DEBUG);

            Logger.message("Hello World!", ALogger.DEBUG);

            string url = "https://www.simbirsoft.com/";

            TextDownloaderAgility textDownloaderAgility = new TextDownloaderAgility();

            Logger.message(textDownloaderAgility.downloadText(url), ALogger.DEBUG);

        }


    }
}
