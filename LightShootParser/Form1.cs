using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LightShootParser
{
   
            
public partial class MainForm : Form
{

        List<string> links = new List<string>();
        bool isWork = true;
        int minLenth = 5;
        string ScreenPath;
        int maxLenth = 7;
        public MainForm()
        {
            InitializeComponent();


        }

        public async void DowloadScreen() 
        {
            await Task.Run(() =>
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

                        ScreenLabel.Text = "Starting work...";
                        if (result.Trim() != "")
                        {

                            ScreenLabel.Text = $"Downloading image: {result}";
                            web.DownloadFile(result, ScreenPath + Path.GetFileName(result).Replace('/', ' '));
                            Thread.Sleep(500);
                        }

                    }
                    catch (Exception ex)
                    {

                        ScreenLabel.Text = "Error";
                    }

                }
                Thread.Sleep(100);
            }
            );
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



        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                PathButton.Text = folderBrowserDialog.SelectedPath;
                downloader.ScreenPath = folderBrowserDialog.SelectedPath;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            StartMethod();
        }

        private async void StartMethod()
        {

            await Task.Run(() =>
            {
                int time;
                if (!int.TryParse(TimeTextBox.Text, out time))
                {
                    MessageBox.Show("Invalid value of time!");
                    return;
                }
                int threadCount;
                threadCount = (int)ThreadNumericUpDown.Value;

                Thread thread = new Thread(DowloadScreen);
                thread.IsBackground = true;
                for (int i = 0; i < threadCount; i++)
                {

                    new Thread(DowloadScreen).Start();
                }
                if (time != 0)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(time));
                    isWork = false;
                    return;
                }
                else
                {
                    while (true)
                    {
                        Thread.Sleep(TimeSpan.FromDays(10));
                    }
                }
                Close();
            }
            );
        }
    }
}
