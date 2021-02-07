using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SnippitApp
{
    public class JsonWriter : Writer
    {
        public string jsonwriterstring = new string("");
        private string _filePath = "../../../Db/Testlist.json";

        public void WriteTo(List<CodeSnippit> thelist)
        {
            var options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.WriteIndented = true;
            string maybe = JsonSerializer.Serialize(thelist); ;
            File.WriteAllText(_filePath, maybe);
        }
    }
}