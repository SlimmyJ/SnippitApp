using System;
using System.Collections.Generic;
using System.Text;

namespace SnippitApp
{
    public class CodeSnippit
    {
        private int _uID { get; set; }
        public string SnipName { get; set; }
        public string SnipSummary { get; set; }
        public string SnipContent { get; set; }

        public int ID
        {
            get { return _uID; }
            set { _uID = value; }
        }

        public List<Tags> SnipTags { get; set; }
        public string SnipAuthor { get; set; }

        public int SnipLength { get; set; }

        public int MyProperty { get; set; }

        public CodeSnippit(string name, string author, string summary, string content)
        {
            SnipName = name;
            SnipAuthor = author;
            SnipSummary = summary;
            SnipContent = content;
        }

        public override string ToString()
        {
            return $"{SnipName}|{SnipAuthor}|{SnipSummary}";
        }
    }
}