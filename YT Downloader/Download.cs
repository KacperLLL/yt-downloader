using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using System.Drawing;


namespace YT_Downloader
{
    internal class Download
    {
        private readonly YoutubeClient _youtube;
        private string _id;
        private string _url;
        private bool _is_busy;
        private YoutubeExplode.Videos.Video _video;
        private TimeSpan? _duration;
        private string _save_path;
        private string _title;
        private string _description;
        private YoutubeExplode.Common.Author _author;
        private string _thumbnailUrl;
        private System.Drawing.Image _thumbnail;
        private SixLabors.ImageSharp.Image _thumbnailSharp;
        private CancellationTokenSource _cts;
        private CancellationToken _token;

        public Download(string URL) { 
            //ustawienia klienta pobierania
            _url= URL;
            _youtube = new YoutubeClient();
            _is_busy = false;
            _cts = new CancellationTokenSource();
            _token = _cts.Token;
        }

        public async Task GetDataAsync()
        {
            try
            {
                //ustawienie podstawowych metadanych
                _video = await _youtube.Videos.GetAsync(_url);
                _duration = _video.Duration;
                _title = _video.Title;
                _description = _video.Description;
                _author = _video.Author;
                _id = _video.Id;
            }
            catch
            {
                 throw;
            }
        }

        public async Task StartAsync(Path PATH)
        {
            _save_path = PATH.GetPath();
            try
            {
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path + _title + ".mp4");
                _is_busy = false;
            }
            catch
            {
                throw;
            }
            

        }
        public async Task StartAsync(Path PATH, Progress<double> PROGRESS)
        {
            _save_path = PATH.GetPath();
            try
            {   
                _is_busy = true;
                await _youtube.Videos.DownloadAsync(_url, _save_path+_title+".mp4", PROGRESS, _token);
                _is_busy = false;

            }
            catch
            {
                throw;
            }

         }



        public void CancelDownload()
        {
            try
            {
                if (_is_busy)
                {
                    //jeżeli jest pobieranie, anuluj je
                    _cts.Cancel();

                    //poczekaj na zakończenie pobierania i usunięcie pliku tymczasowego
                    while (_is_busy) ;
                    if (File.Exists(_save_path + _title + ".mp4.stream-1.tmp"))
                    {
                        File.Delete(_save_path + _title + ".mp4.stream-1.tmp");
                    }
                }
            }
            catch
            {
                throw;
            }
        }



        public async Task DownloadThumbnailAsync()
        {
            //pobieranie miniatury
            _thumbnailUrl = _video.Thumbnails.GetWithHighestResolution().Url;
            using (HttpClient http = new())
            {
                var imageData = await http.GetByteArrayAsync(_thumbnailUrl);
                _thumbnailSharp = SixLabors.ImageSharp.Image.Load<Rgba32>(new MemoryStream(imageData));
                _thumbnail = ConvertImageSharpToSystemImage(_thumbnailSharp);
            }
        }
        private System.Drawing.Image ConvertImageSharpToSystemImage(SixLabors.ImageSharp.Image imageSharp)
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    imageSharp.SaveAsPng(ms);
                    ms.Seek(0, SeekOrigin.Begin);
                    return System.Drawing.Image.FromStream(ms);
                }
            }
            catch
            {
                throw;
            }
        }


        public string id { get { return _id; } }
        public SixLabors.ImageSharp.Image thumbnaiSharp { get { return _thumbnailSharp; } }
        public System.Drawing.Image thumbnail { get { return _thumbnail; } }
        public string url { get { return _url;} set { _url = value; } }
        public string save_path { get { return _save_path;} set { _save_path = value; } }
        public bool is_busy { get { return _is_busy; } }
        public TimeSpan? duration { get { return _duration; } }
        public string title { get { return _title; } }
        public string description { get { return _description; } }
        public Author author { get { return _author; } }
    }
}
