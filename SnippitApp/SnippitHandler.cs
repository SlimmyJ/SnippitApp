using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Linq;

namespace SnippitApp
{
    public class SnippitHandler
    {
        private List<CodeSnippit> _snippitList;

        //private SnippitList _snippitList;
        private IReader _reader;

        private JsonWriter _writer;
        private DataBaseWriter _databaseWriter;
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
            _reader = new DataBaseReader();
            _writer = new JsonWriter();
            _databaseWriter = new DataBaseWriter();
            //_snippitList = new SnippitList();
            CreateSnippitList();
        }

        public List<CodeSnippit> GetSnippitList()
        {
            return _snippitList;
        }

        public BindingList<CodeSnippit> GetBindingSnippitList()
        {
            BindingList<CodeSnippit> temp = new BindingList<CodeSnippit>();
            _snippitList.Clear();
            CreateSnippitList();

            _snippitList.ForEach(CodeSnippit => temp.Add(CodeSnippit));


            //foreach (var i in _snippitList)
            //{
            //    temp.Add(i);
            //}

            return temp;
        }

        public void CreateSnippitList()
        {
            _snippitList = _reader.GetSnippitList();
        }

        public void WriteToFile(List<CodeSnippit> list)
        {
            _writer.WriteTo(_snippitList);
            //_databaseWriter.WriteTo(_snippitList[_snippitList.Count]);
            _databaseWriter.WriteTo(_snippitList.LastOrDefault());
        }

        public void AddToList(CodeSnippit codesnippit)
        {
            _snippitList.Add(codesnippit);
        }

        public void DeleteFromList(CodeSnippit snippit)
        {
            //_snippitList.Remove(codesnippit);
            _databaseWriter.DeletePost(snippit);
        }

        public void UpdateSnippit(CodeSnippit snippit)
        {
            _databaseWriter.UpdatePost(snippit);
        }

        public CodeSnippit GetSnippîtFromList(int index)
        {
            return _snippitList[index];
        }
    }
}