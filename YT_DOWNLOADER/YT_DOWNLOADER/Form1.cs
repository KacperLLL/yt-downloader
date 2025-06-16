using Microsoft.Web.WebView2.WinForms;
using System;
using System.Threading.Tasks;
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
                Query querry = new Query(args.TryGetWebMessageAsString());

                if(querry.type == QueryType.Search)
                {
                    Search search = new Search();
                    List<>await search.SearchVideosAsync(querry.args[0], int.Parse(querry.args[1]));

                    
                }

                await webView.ExecuteScriptAsync("reciveSearch('Q');");
            };
        }
    }
}
