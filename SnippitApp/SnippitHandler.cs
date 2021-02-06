using System.Collections.Generic;
using System;

namespace SnippitApp
{
    public class SnippitHandler
    {
        private List<CodeSnippit> _snippitList;
        private List<IObservable<CodeSnippit>> observables;
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

        public void WriteToFile(List<CodeSnippit> list)
        {
            _writer.ToJson(_snippitList);
        }

        public void AddToList(CodeSnippit codesnippit)
        {
            _snippitList.Add(codesnippit);
        }

        public void DeleteFromList(CodeSnippit codesnippit)
        {
            //_snippitList.Remove(codesnippit);
        }
    }
}