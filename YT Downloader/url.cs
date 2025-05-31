using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_Downloader
{
    internal class Path
    {
        private string _path;
        public Path(string PATH)
        {
            if(PATH is not null)
            {
                //konwersja ścieżki pliku zapisu tak aby występowały podwójne backslahe nie było spacji i kończyło się dwoma backslashami
                _path = PATH.Replace(@"\", @"\\").Replace(" ", "_").TrimEnd('\\') + @"\\";

            }
            else
            {
                throw new ArgumentNullException(nameof(PATH), "URL cannot be null");
            }
        }

        public string GetPath()
        {
            return _path;
        }
        public void SetNewPath(string PATH)
        {
            if (PATH is not null)
            {
                //konwersja ścieżki pliku zapisu tak aby występowały podwójne backslahe nie było spacji i kończyło się dwoma backslashami
                _path = PATH.Replace(@"\", @"\\").Replace(" ", "_").TrimEnd('\\') + @"\\";

            }
            else
            {
                throw new ArgumentNullException(nameof(PATH), "URL cannot be null");
            }
        }

    }
}
