using System.Collections.Generic;

namespace SnippitApp
{
    public class CodeSnippit
    {
        private static int id = 0;

        private int myId = 0;
        public string SnipName { get; set; }
        public string SnipSummary { get; set; }
        public string SnipContent { get; set; }

        public int SnipID
        {
            get { return myId; }
            set { myId = value; }
        }

        public List<Tags> SnipTags { get; set; }
        public string SnipAuthor { get; set; }

        public int SnipLength { get; set; }

        public int MyProperty { get; set; }

        public CodeSnippit()
        {
        }

        public CodeSnippit(string name, string summary, string content, string author = "unknown")
        {
            id++;
            SnipID =  id;
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