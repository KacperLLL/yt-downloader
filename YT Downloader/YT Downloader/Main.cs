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
            Console.WriteLine("Podaj link do filmu z YouTube:");
            var videoUrl = Console.ReadLine();
            var path = "video.mp4";

            if(videoUrl is not null)
            {
                Download download = new Download(videoUrl, path);
                
                await download.StartDownload();
            }
            else
            {
                Console.WriteLine("BLAD");
            }
        }
    }
}
