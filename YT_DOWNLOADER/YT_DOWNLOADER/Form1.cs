using Microsoft.Web.WebView2.WinForms;
using System;
using System.Threading.Tasks;

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
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await JsCommunicationHandle();
        }

        private async Task JsCommunicationHandle()
        {
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.WebMessageReceived += async (sender, args) =>
            {
                string message = args.TryGetWebMessageAsString();
                if (message == "search")
                {
                    MessageBox.Show("Search button clicked!");
                    await webView.ExecuteScriptAsync("Test('FLAG');");
                }
            };
        }
    }
}
