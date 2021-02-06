using System.Collections.Generic;

namespace SnippitApp
{
    public class SnippitHandler
    {
        private List<CodeSnippit> _snippitList;
        private IReader _reader;
        private IWriter _writer;
        private static SnippitHandler snippitHandler;

        public static SnippitHandler GetSnippitHandler()
        {
            if (snippitHandler == null)
            {
                snippitHandler = new SnippitHandler();
            }

            return snippitHandler;
        }

        private SnippitHandler()
        {
            _reader = new JsonReader();
            _writer = new JsonWriter();
            CreateSnippitList();
        }

        public List<CodeSnippit> GetSnippitList()
        {
            return _snippitList;
        }

        public void CreateSnippitList()
        {
            _snippitList = _reader.GetSnippitListFromJson();
        }

        public void WriteToList()
        {
        }

        public void AddToList()
        {
        }

        public void DeleteFromList()
        {
        }
    }
}