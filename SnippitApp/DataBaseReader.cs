using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace SnippitApp
{
    internal class DataBaseReader : IReader
    {
        public string _jsonString { get; private set; }

        public List<CodeSnippit> GetSnippitList()
        {
            List<CodeSnippit> snippits = new List<CodeSnippit>();

            string url = @"https://snippit-app.herokuapp.com/snippits";
            WebClient client = new WebClient();
            string response = client.DownloadString(url);

            snippits = JsonConvert.DeserializeObject<List<CodeSnippit>>(response);

            return snippits;
        }
    }
}