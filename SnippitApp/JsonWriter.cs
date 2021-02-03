using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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