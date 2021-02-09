using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using SnippitApp.Loggers;

namespace SnippitApp
{
    internal class DataBaseReader : IReader
    {
        public string _jsonString { get; private set; }

        public List<CodeSnippit> GetSnippitList()
        {
            var url = @"https://snippit-app.herokuapp.com/snippits";
            WebClient client = new WebClient();
            var response = client.DownloadString(url);

            var snippits = JsonConvert.DeserializeObject<List<CodeSnippit>>(response);

            return snippits;
        }
    }
}