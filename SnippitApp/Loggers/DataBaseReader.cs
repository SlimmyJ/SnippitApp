using Newtonsoft.Json;
using SnippitApp.Snippits;
using System.Collections.Generic;
using System.Net;

namespace SnippitApp.Loggers
{
    internal class DataBaseReader : IReader
    {
        public string JsonString { get; private set; }

        public List<CodeSnippit> GetSnippitList()
        {
            const string url = @"https://snippit-app.herokuapp.com/snippits";
            WebClient client = new WebClient();
            var response = client.DownloadString(url);

            var snippits = JsonConvert.DeserializeObject<List<CodeSnippit>>(response);

            return snippits;
        }
    }
}