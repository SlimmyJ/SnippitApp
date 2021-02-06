using System.Collections.Generic;

namespace SnippitApp
{
    public class SnippitRepo
    {
        public List<CodeSnippit> SnippitListRepo;
        public JsonReader Jasonbro;
        public JsonWriter Jasonsis;

        public SnippitRepo()
        {
            Jasonbro = new JsonReader();
            Jasonsis = new JsonWriter();
        }
    }
}