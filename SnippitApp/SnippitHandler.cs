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

            _snippitList.ForEach(CodeSnippit => temp.Add(CodeSnippit));

            //foreach (var i in _snippitList)
            //{
            //    temp.Add(i);
            //}

            return temp;
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