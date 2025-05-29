using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YT_Downloader.Download;
using static YT_Downloader.Search;
using static YT_Downloader.url;

namespace YT_Downloader
{
    internal class Start
    {

        static async Task Main()
        {
            url URL = new(@"C:\Users\Kacper\Desktop\yt-downloader\YT Downloader");
            Console.WriteLine(URL.GetUrl());

        }


        private static async Task TestSearch()
        {
            var path = "C:\\Users\\Kacper\\Desktop\\temp\\";
            Console.WriteLine("Search: ");
            var consoleInput = Console.ReadLine();

            try
            { 
                YT_Downloader.Search search = new();
                var results = await search.SearchVideosAsync(consoleInput, 10);

                foreach(Download result in results)
                {
                    Console.WriteLine("Wyszykiwanie nr: " + (results.IndexOf(result) + 1));
                    Console.WriteLine($"Tytuł: {result.title}");
                    Console.WriteLine($"Autor: {result.author.ChannelTitle}");
                    Console.WriteLine($"Link: {result.url}");
                    Console.WriteLine($"Czas trwania: {result.duration}");
                    Console.WriteLine("--------------------------------------------------");
                }

                Console.WriteLine("\nKtóry film pobrać? (wpisz numer)");
                var input = Console.ReadLine();

                var progress = new Progress<double>(p =>
                {
                    Console.Write($"\rPostęp pobierania: {p:P1}");
                });

                await results[int.Parse(input) - 1].StartAsync(path, progress);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas wyszukiwania: " + ex.Message);
            }




        }

        private static async Task TestDownload()
        {
            var path = "C:\\Users\\Kacper\\Desktop\\temp\\";
            var videoUrl = "https://www.youtube.com/watch?v=VQRLujxTm3c&t=4s&ab_channel=RockstarGames";

            if (videoUrl is not null)
            {
                Download download = new(videoUrl);

                await download.GetDataAsync();

                Console.WriteLine("Rozpoczęto pobieranie: " + download.title + "; " + download.duration + "; " + download.author.ChannelTitle);

                var progress = new Progress<double>(p =>
                {
                    Console.Write($"\rPostęp pobierania: {p:P1}");
                });

                try
                {
                    download.StartAsync(path, progress);
                    var anul = Console.ReadLine();

                    if (anul == "N")
                    {
                        download.CancelDownload();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd podczas pobierania: " + ex.Message);
                }

            }
            else
            {
                Console.WriteLine("BLAD");
            }
        }

    }
}
