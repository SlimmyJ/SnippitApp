using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SnippitApp
{
    public class JsonWriter
    {
        private string jsonstring = new string("");

        public void ToJson(List<CodeSnippit> thelist)
        {
            jsonstring = JsonSerializer.Serialize(thelist);
            File.WriteAllText("Testlist", jsonstring);
        }
    }
}