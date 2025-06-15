using Microsoft.Web.WebView2.WinForms;
using System;
using System.Threading.Tasks;

namespace YT_DOWNLOADER
{
    enum QueryType
    {
        Search,
        Null
    }

    public class Query
    {
        Query(string q)
        {

        }
    }


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
                //await webView.ExecuteScriptAsync($"alert('{args.TryGetWebMessageAsString()}');");
                object sasd = TrimQuery(args.TryGetWebMessageAsString());
            };
        }

        private (type: QueryType, args: string[]) TrimQuery(string Q)
        {
            string[] args = Array.Empty<string>();

            if (Q.StartsWith("#SEARCH"))
            {
                Q = Q.Replace("#SEARCH_", "");

                args = Q.Split('_');
                
                return (QueryType.Search, args);
            }

            return (QueryType.Null, args);
        }
    }
}
