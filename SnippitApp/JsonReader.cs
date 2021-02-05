using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SnippitApp
{
    public class JsonReader
    {
        public string _jsonString { get; private set; }

        private string _filePath;

        public List<CodeSnippit> GetSnippitListFromJson(string fileName)
        {
            List<CodeSnippit> CodeSnippitList = new List<CodeSnippit>();
            _jsonString = File.ReadAllText(fileName);
            CodeSnippitList = JsonSerializer.Deserialize<List<CodeSnippit>>(_jsonString);
            return CodeSnippitList;
        }
    }
}