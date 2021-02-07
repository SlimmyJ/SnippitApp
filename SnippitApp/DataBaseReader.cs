using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SnippitApp
{
    class DataBaseReader : IReader
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
