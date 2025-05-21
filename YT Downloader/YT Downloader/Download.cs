using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;
using System.Text.RegularExpressions;
using YoutubeExplode.Common;

namespace YT_Downloader
{
    internal class Download
    {
        private readonly YoutubeClient _youtube;
        private string _url;
        private string _save_path;
        private bool _is_busy;
        private readonly System.Threading.Tasks.ValueTask<YoutubeExplode.Videos.Video> _video;
        private readonly TimeSpan? _duration;
        private readonly string _title;
        private readonly string _description;
        private readonly YoutubeExplode.Common.Author _author;

        public Download(string URL, string SAVE_PATH) { 
            _url= URL;
            _youtube = new YoutubeClient();
            _save_path= SAVE_PATH;
            _is_busy = false;

            _video = _youtube.Videos.GetAsync(_url);
            _duration = _video.Result.Duration;
            _title = _video.Result.Title;
            _description = _video.Result.Description;
            _author = _video.Result.Author;
                
            
        }


        public async Task StartDownload()
        {
            Console.WriteLine("Rozpoczenczie pobierania: ");

            try
            {
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Zakonczono pobieranie");
                _is_busy = false;
            }
            

        }
        public async Task StartDownload(Progress<double> PROGRESS)
        {
            Console.WriteLine("Rozpoczenczie pobierania: ");
            Console.WriteLine(_duration.ToString() + " " + _title.ToString()+" "+_author.ChannelTitle);

            try
            {   
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path, PROGRESS);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Zakonczono pobieranie");
                _is_busy = false;
            }
        }
        public async Task StartDownload(Progress<double> PROGRESS, CancellationToken TOKEN)
        {
            Console.WriteLine("Rozpoczenczie pobierania: ");

            try
            {
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path, PROGRESS, TOKEN);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Zakonczono pobieranie");
                _is_busy = false;
            }
        }




        public YoutubeClient youtube { get { return _youtube; } }
        public System.Threading.Tasks.ValueTask<YoutubeExplode.Videos.Video> video { get { return _video; } }
        public string url { get { return _url;} set { _url = value; } }
        public string save_path { get { return _save_path;} set { _save_path = value; } }
        public bool is_busy { get { return _is_busy; } }
        public TimeSpan? duration { get { return _duration; } }
        public string title { get { return _title; } }
        public string description { get { return _description; } }
        public YoutubeExplode.Common.Author author { get { return _author; } }
    }
}
