using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SnippitApp
{
    public class JsonReader : IReader
    {
        public string _jsonString { get; private set; }

        private string _filePath = @"C:\Users\simon\source\repos\SnippitApp\SnippitApp\bin\Debug\netcoreapp3.1\Testlist.json";

        public List<CodeSnippit> GetSnippitListFromJson()
        {
            _jsonString = File.ReadAllText(_filePath);
            List<CodeSnippit> CodeSnippitList = new List<CodeSnippit>();
            CodeSnippitList = JsonSerializer.Deserialize<List<CodeSnippit>>(_jsonString);
            return CodeSnippitList;
        }
    }
}