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

        static async Task Main()
        {
            var path = "C:\\Users\\kacpe\\Desktop\\temp\\";
            var videoUrl = "https://www.youtube.com/watch?v=VQRLujxTm3c&t=4s&ab_channel=RockstarGames";

            if (videoUrl is not null)
            {
                Download download = new(videoUrl, path);

                await download.GetDataAsync();

                Console.WriteLine("Rozpoczęto pobieranie: " + download.title + "; " + download.duration + "; " + download.author.ChannelTitle);

                var progress = new Progress<double>(p =>
                {
                    Console.Write($"\rPostęp pobierania: {p:P1}");
                });

                download.StartAsync(progress);
                var anul = Console.ReadLine();

                if(anul=="N")
                {
                    download.CancelDownload();
                }

            }
            else
            {
                Console.WriteLine("BLAD");
            }
        }

    }
}
