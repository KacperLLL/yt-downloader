using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT_DOWNLOADER
{
    public enum QueryType
    {
        Search,
        Null
    }

    public class Query
    {
        private string[] _args = Array.Empty<string>();
        private QueryType _type = QueryType.Null;
        public Query(string Q)
        {
            _args = Array.Empty<string>();
            _type = QueryType.Null;
        }
        public string[] args { get { return _args; } }
        public QueryType type { get { return _type; } }
    }
}
