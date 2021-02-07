namespace SnippitApp
{
    public class CodeSnippit
    {
        //private static int _snipId = 0;
        public string _id { get; set; }

        public string name { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public string summary { get; set; }

        //public int sniplength { get; set; }

        //public int myproperty { get; set; }

        public CodeSnippit()
        {
        }

        public CodeSnippit(string name, string summary, string content)
        {
            this.name = name;

            this.summary = summary;
            this.content = content;
            author = "u dikke ma";
        }

        public override string ToString()
        {
            return $"{name} | {summary}";
        }
    }
}