using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using YoutubeExplode.Search;
using YT_Downloader;
using YT_DOWNLOADER;

namespace YT_DOWNLOADER
{
    public partial class Form1 : Form
    {
        private WebView2 webView;

        public Form1()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(webView);

            await webView.EnsureCoreWebView2Async(null);
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(@"\", "/");
            string resultPath = @"file:///" + exePath.Replace(@"bin/Debug/net6.0-windows/YT_DOWNLOADER.dll", "") + "GUI/index.html";
            webView.Source = new Uri(resultPath);

            webView.CoreWebView2.NavigationCompleted += async (s, e) =>
            {
                await JsCommunicationHandle();
            };
        }

        private async Task JsCommunicationHandle()
        {
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.WebMessageReceived += async (sender, args) =>
            {
                Query query = new(args.TryGetWebMessageAsString());
                await query.RunAsync();
                string serialized = JsonConvert.SerializeObject(query.Serialize());
                await webView.ExecuteScriptAsync($"reciveSearch({serialized});");
                File.WriteAllText("query.json", query.Serialize());
            };
        }
    }
} 
