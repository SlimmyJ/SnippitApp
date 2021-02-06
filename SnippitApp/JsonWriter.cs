using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SnippitApp
{
    public class JsonWriter
    {
        private string jsonwriterstring = new string("");

        public void ToJson(List<CodeSnippit> thelist)
        {
            jsonwriterstring = JsonSerializer.Serialize(thelist);
            File.WriteAllText("Testlist", jsonwriterstring);
        }
    }
}