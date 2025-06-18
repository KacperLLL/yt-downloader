using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using YoutubeExplode.Search;
using YT_Downloader;

namespace YT_DOWNLOADER
{
    public interface IQueryStrategy
    {
        public Task RunAsync();
        public string Serialize();
    }

    public class SearchQuery : IQueryStrategy
    {
        private Search _search;

        public SearchQuery(){
            _search = new Search();
            results = new();
        }

        public async Task RunAsync(){
            results = await _search.SearchVideosAsync(query_text, max_count);
        }

        public string Serialize(){
            return JsonConvert.SerializeObject(this);
        }


        public List<VideoSearchResult> results {get; set;}
        public int max_count { private get;  set; }
        public string query_text { private get; set; }

    }

    public class Query
    {
        private IQueryStrategy _strategy;
        
        public Query(string json)
        {
            using var doc = JsonDocument.Parse(json);
            string type = doc.RootElement.GetProperty("type").GetString();

            switch (type.ToLower())
            {
                case "search":
                    _strategy = JsonConvert.DeserializeObject<SearchQuery>(json);
                    break;
                default:
                    throw new ArgumentException("Nieznany typ zapytania.");
            }
        }

        public async Task RunAsync(){
            await _strategy.RunAsync();
        }
        public string Serialize(){
            return _strategy.Serialize();
        }
    }
}
