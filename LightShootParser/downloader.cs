using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightShootParser
{
    class downloader : Form
    {
      
        List<string> links { get; set; } = new List<string> { };
        static public bool isWork { get; set; } = true;
        static public int minLenth { get; set; }
        static public string ScreenPath { get; set; }
        static public int maxLenth { get; set; }
        public void GetImageToFloader()
        {
            string[] Agents = {"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0",
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36",
                "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.90 Safari/537.36"
            };

            Random random = new Random();
            WebClient web = new WebClient { Encoding = Encoding.UTF8 }; ;
            Regex rgx = new Regex("<img\\W+class=\".+\"\\W+src=\"(.+)\"\\W+cr");
            while (isWork)
            {
                string link = GenerateString(random.Next(minLenth, maxLenth));
                
                try
                {

                    web.Headers["User-Agent"] = Agents[random.Next(1, Agents.Length)];
                    string html = web.DownloadString(link);
                    string result = rgx.Match(html).Groups[1].Value;
                    if (result.Trim() != "")
                    {
                        Console.WriteLine("Downloading photos... " + result);
                        web.DownloadFile(result, ScreenPath + Path.GetFileName(result).Replace('/', ' '));
                        Thread.Sleep(500);
                    }

                }
                catch (Exception ex)
                {
                }

                }
                Thread.Sleep(100);
        }

        public string GenerateString(int length)
        {
            Random random = new Random();
            string link = @"https://prnt.sc/";
            string chars = "abcdefghijklmnopqrstuvwxyz1234567890";
            for (int i = 0; i < length; i++)
            {
                link += chars.Substring(random.Next(1, chars.Length), 1);
            }
            if (!links.Contains(link))
            {
                links.Add(link);
                return link;
            }
                return "";
        }




    }
}
