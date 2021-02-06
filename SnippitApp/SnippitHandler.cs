using System.Collections.Generic;

namespace SnippitApp
{
    public class SnippitHandler
    {
        private List<CodeSnippit> _snippitList;
        private IReader _reader;
        private IWriter _writer;

        public SnippitHandler()
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
    }
}