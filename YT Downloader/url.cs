using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Downloader
{
    internal class url
    {
        private string _url;
        public url(string URL)
        {
            if(URL is not null)
            {
                if(URL.StartsWith(@"https://www.youtube")||URL.StartsWith(@"www.youtube"))
                {
                    //konwersja linku do Youtube


                }
                else
                {
                    //konwersja ścieżki pliku zapisu tak aby występowały podwójne backslahe nie było spacji i kończyło się dwoma backslashami
                    _url = URL.Replace(@"\", @"\\").Replace(" ", "_").TrimEnd('\\') + @"\\";
                }

            }
            else
            {
                throw new ArgumentNullException(nameof(URL), "URL cannot be null");
            }
        }

        public string GetUrl()
        {
            return _url;
        }

    }
}
