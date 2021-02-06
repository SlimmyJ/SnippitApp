using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization;

namespace SnippitApp
{
    public class JsonWriter
    {
        public string jsonwriterstring = new string("");
        private string _filePath = @"C:\Users\simon\source\repos\SnippitApp\SnippitApp\bin\Debug\netcoreapp3.1\Testlist.json";

        public void ToJson(List<CodeSnippit> thelist)
        {
            var options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.WriteIndented = true;
            string maybe = JsonSerializer.Serialize(thelist); ;
            File.WriteAllText(_filePath, maybe);
        }
    }
}