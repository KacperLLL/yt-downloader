using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Diagnostics;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace YT_Downloader
{
    internal class Download
    {
        private readonly YoutubeClient _youtube;
        private string _url;
        private string _save_path;
        private bool _is_busy;
        private YoutubeExplode.Videos.Video _video;
        private TimeSpan? _duration;
        private string _title;
        private string _description;
        private YoutubeExplode.Common.Author _author;
        private string _thumbnailUrl;
        private Image _thumbnai;

        public Download(string URL, string SAVE_PATH) { 
            //ustawienia klienta pobierania
            _url= URL;
            _youtube = new YoutubeClient();
            _save_path= SAVE_PATH;
            _is_busy = false;
        }

        public async Task GetDataAsync()
        {
            //ustawienie podstawowych metadanych
            _video = await _youtube.Videos.GetAsync(_url);
            _duration = _video.Duration;
            _title = _video.Title;
            _description = _video.Description;
            _author = _video.Author;

            //pobieranie miniatury
            _thumbnailUrl = _video.Thumbnails.GetWithHighestResolution().Url;
            using (HttpClient http = new())
            {
                var imageData = await http.GetByteArrayAsync(thumbnailUrl);
                using Image image = Image.Load<Rgba32>(new MemoryStream(imageData));
            }
        }

        public async Task StartAsync()
        {
            Console.WriteLine("Rozpoczenczie pobierania: ");

            try
            {
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path + _title + ".mp4");
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
        public async Task StartAsync(Progress<double> PROGRESS)
        {
            Console.WriteLine("Rozpoczenczie pobierania: ");
            Console.WriteLine(_duration.ToString() + " " + _title.ToString()+" "+_author.ChannelTitle);

            try
            {   
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path+_title+".mp4", PROGRESS);

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
        public async Task StartAsync(Progress<double> PROGRESS, CancellationToken TOKEN)
        {
            Console.WriteLine("Rozpoczenczie pobierania: ");

            try
            {
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path + _title + ".mp4", PROGRESS, TOKEN);
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




        public Image thumbnai { get; }
        public YoutubeClient youtube { get { return _youtube; } }
        public YoutubeExplode.Videos.Video video { get { return _video; } }
        public string url { get { return _url;} set { _url = value; } }
        public string save_path { get { return _save_path;} set { _save_path = value; } }
        public bool is_busy { get { return _is_busy; } }
        public TimeSpan? duration { get { return _duration; } }
        public string title { get { return _title; } }
        public string description { get { return _description; } }
        public string thumbnailUrl { get { return _thumbnailUrl; } }
        public Author author { get { return _author; } }
    }
}
