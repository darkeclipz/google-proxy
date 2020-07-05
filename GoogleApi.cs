using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace GoogleProxy
{
    public static class GoogleApi
    {
        public static async Task<IEnumerable<Uri>> GetSearchResultsAsync(string query)
        {
            return await Task.Run(() => {
                var url = GetUrl(HttpUtility.UrlEncode(query));
                using var wc = new WebClient();
                var html = wc.DownloadString(url);
                var regex = new Regex("https?:\\/\\/[a-zA-Z0-9/\\?=\\-&_#.;]*\"");
                var matches = regex.Matches(html);
                return matches
                    .Select(m => new Uri(SanitizeUrl(m.Value)))
                    .Where(url => !url.Host.Contains("google"));
            });
        }

        public static async Task<(string, string)> GetMetadataAsync(string url)
        {
            return await Task.Run(() => {
                Thread.Sleep(750);
                return ("Title", "Description");
            });
        }

        private static string SanitizeUrl(string url)
        {
            if(url.Contains("&amp;")) 
            {
                return url.Split("&amp;")[0];
            }
            
            return url;
        }

        private static Uri GetUrl(string query) => new Uri($"https://www.google.com/search?q={query}");
    }
}