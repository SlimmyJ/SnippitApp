using SnippitApp.Loggers;
using SnippitApp.Snippits;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SnippitApp
{
    public class SnippitHandler
    {
        private List<CodeSnippit> _snippitList;
        private readonly IReader _reader;
        private readonly JsonWriter _writer;
        private readonly DataBaseWriter _databaseWriter;
        private static SnippitHandler _snippitHandler;

        public static SnippitHandler GetSnippitHandler()
        {
            return _snippitHandler ??= new SnippitHandler();
        }

        private SnippitHandler()
        {
            _reader = new DataBaseReader();
            _writer = new JsonWriter();
            _databaseWriter = new DataBaseWriter();
            CreateSnippitList();
        }

        public List<CodeSnippit> GetSnippitList()
        {
            return _snippitList;
        }

        public BindingList<CodeSnippit> GetBindingSnippitList()
        {
            BindingList<CodeSnippit> temp = new BindingList<CodeSnippit>();
            CreateSnippitList();
            _snippitList.ForEach(codeSnippit => temp.Add(codeSnippit));

            return temp;
        }

        public void CreateSnippitList()
        {
            _snippitList = _reader.GetSnippitList();
        }

        public void WriteToFile(List<CodeSnippit> list)
        {
            _databaseWriter.WriteTo(_snippitList.LastOrDefault());
            _writer.SaveList(_snippitList);
        }

        public void AddToList(CodeSnippit codesnippit)
        {
            _snippitList.Add(codesnippit);
        }

        public void DeleteFromList(CodeSnippit snippit)
        {
            _databaseWriter.DeletePost(snippit);
        }

        public void UpdateSnippit(CodeSnippit snippit)
        {
            _databaseWriter.UpdatePost(snippit);
        }

        public CodeSnippit GetSnippitFromList(int index)
        {
            return _snippitList[index];
        }
    }
}