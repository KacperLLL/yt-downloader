using Microsoft.VisualBasic;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;
using static YT_Downloader.Download;

namespace YT_Downloader
{
    internal class Search
    {
        private YoutubeClient _youtube;

        public Search()
        {
            _youtube = new YoutubeClient();
        }

        /*public async Task<List<Download>> SearchVideosAsync(string query, int maxResults)
        {

            List<Download> results = new List<Download>();

            try
            {

                await foreach (var res in _youtube.Search.GetResultsAsync(query))
                {
                    if (res is VideoSearchResult)
                    {
                        Download download = new Download(res.Url);
                        await download.GetDataAsync();
                        results.Add(download);
                    }
                    
                    if(results.Count>=maxResults)
                    {
                        return results;
                    }

                    
                }
                return results;

            }
            catch
            {
                throw;
            }
        }*/

        public async Task<List<VideoSearchResult>> SearchVideosAsync(string query, int maxResults)
        {

            List<VideoSearchResult> results = new List<VideoSearchResult>();

            try
            {

                await foreach (VideoSearchResult res in _youtube.Search.GetResultsAsync(query))
                {
                    if (res is VideoSearchResult)
                    {
                        results.Add(res);
                    }

                    if (results.Count >= maxResults)
                    {
                        return results;
                    }


                }
                return results;

            }
            catch
            {
                throw;
            }
        }


    }
}
