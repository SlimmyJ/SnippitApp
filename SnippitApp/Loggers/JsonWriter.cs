using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SnippitApp.Loggers
{
    public class JsonWriter
    {
        public string Jsonwriterstring = new string("");
        private const string FilePath = "../../../Db/Testlist.json";

        public void SaveList(List<CodeSnippit> thelist)
        {
            var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
            var contents = JsonSerializer.Serialize(thelist); ;
            File.WriteAllText(FilePath, contents);
        }
    }
}