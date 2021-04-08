using SimbirSoftTest.Logger;
using SimbirSoftTest.TextDownloader;
using SimbirSoftTest.TextParser;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimbirSoftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ALogger Logger = null;
            ITextDownloader textDownloaderAgility;
            ATextParser textParser;
            string url;
            string textFromUrl;
            try
            {
                try
                {
                    Logger = LogBuilder.buildLog();
                    Logger.message("Logger build succeful", ALogger.DEBUG);
                }
                catch(Exception e)
                {
                    throw new Exception("Err build logger " + "\n" + e.Message);
                }

                try
                {
                    Console.WriteLine("Enter url for parse words:");
                    //string url = "https://www.simbirsoft.com/";
                    url = Console.ReadLine();
                    Logger.message("Url for parse = "+url, ALogger.DEBUG);
                }
                catch (Exception e)
                {
                    throw new Exception("Err enter url " + "\n" + e.Message);
                }         

                
                try
                {
                    textDownloaderAgility = new TextDownloaderAgility();

                    textFromUrl = textDownloaderAgility.downloadText(url);

                    Logger.message(textFromUrl, ALogger.DEBUG);
                }
                catch (Exception e)
                {
                    throw new Exception("Err download text from " + url + "\n" + e.Message);
                }

                try
                {
                    char[] delimetrs = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' };

                    textParser = new SplitTextParser(delimetrs);

                    IDictionary<string, int> wordsCountDict = textParser.parseText(textFromUrl);

                    var items = from pair in wordsCountDict
                                orderby pair.Value descending
                                select pair;


                    Logger.message(string.Join("\n", items.Select(x => x.Key + " - " + x.Value).ToArray()), ALogger.INF);
                }
                catch (Exception e)
                {
                    throw new Exception("Err download text from " + url + "\n" + e.Message);
                }
            }
            catch (Exception e)
            {
                if (Logger == null)
                {
                    Logger.message(e.Message, ALogger.ERR);
                }
                else
                {
                    Console.WriteLine(e.Message);
                }
            }



        }


    }
}
