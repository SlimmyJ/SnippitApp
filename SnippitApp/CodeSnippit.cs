using System.Collections.Generic;

namespace SnippitApp
{
    public class CodeSnippit
    {
        private int _snipId = 0;
        public string SnipName { get; set; }
        public string SnipSummary { get; set; }
        public CodeinSnippit Codestring { get; set; }

        public string SnipContent { get; set; }

        public int SnipID
        {
            get { return _snipId; }
            set { _snipId = value; }
        }

        public List<Tag> SnipTags { get; set; }
        public string SnipAuthor { get; set; }

        public int SnipLength { get; set; }

        public int MyProperty { get; set; }

        public CodeSnippit()
        {
        }

        public CodeSnippit(string name, string summary, string content, string author = "unknown")
        {
            _snipId++;
            SnipID = _snipId = 0;
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