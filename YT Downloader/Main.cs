using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YT_Downloader.Download;
using static YT_Downloader.Search;
using static YT_Downloader.Path;
using YoutubeExplode.Search;

namespace YT_Downloader
{
    internal class Start
    {

        static async Task Main()
        {
            Search search = new();
            List<VideoSearchResult> results = new List<VideoSearchResult>();
            results = await search.SearchVideosAsync("ale urwał!", 10);

            foreach (var video in results)
            {
                Console.WriteLine($"Video ID: {video.Id}");
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Duration: {video.Duration}");
                Console.WriteLine($"Video URL: {video.Url}");
                Console.WriteLine();

                
            }

            var response = Console.ReadLine();

            foreach (var video in results)
            {
                if (video.Id == response)
                {
                    Console.Clear();
                    Download download = new(video.Url);
                    await download.GetDataAsync();
                    
                    Console.WriteLine($"ID: {download.id}");
                    Console.WriteLine($"Title: {download.title}");
                    Console.WriteLine($"Author: {download.author}");
                    Console.WriteLine($"Duration: {download.duration}");
                    Console.WriteLine($"Description: {download.description}");
                    Console.WriteLine($"URL: {download.url}");


                }

            }


        }

    }
}
