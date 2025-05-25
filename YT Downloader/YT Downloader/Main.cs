using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YT_Downloader.Download;

namespace YT_Downloader
{
    internal class Start
    {
        private double _procent= 0;

        static async Task Main()
        {
            Console.WriteLine("Podaj link do filmu z YouTube:");
            var videoUrl = Console.ReadLine();
            Console.WriteLine("Sciezke zapisu:");
            var path = Console.ReadLine();

            if (videoUrl is not null)
            {
                Download download = new(videoUrl, path);

                await download.GetDataAsync();


                var progress = new Progress<double>(p =>
                {
                    Console.Write($"\rPostęp pobierania: {p:P1}");
                });

                await download.StartAsync(progress);

            }
            else
            {
                Console.WriteLine("BLAD");
            }
        }
        public double procent { get { return _procent; } set { _procent = value; } }

    }
}
