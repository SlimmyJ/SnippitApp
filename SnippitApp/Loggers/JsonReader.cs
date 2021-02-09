using SnippitApp.Snippits;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SnippitApp.Loggers
{
    public class JsonReader : IReader
    {
        public string JsonString { get; private set; }

        private readonly string _filePath = "../../../Db/Testlist.json";

        public List<CodeSnippit> GetSnippitList()
        {
            JsonString = File.ReadAllText(_filePath);
            var codeSnippitList = JsonSerializer.Deserialize<List<CodeSnippit>>(JsonString);
            return codeSnippitList;
        }
    }
}