namespace SnippitApp
{
    public class CodeSnippit
    {
        public string _id { get; set; }

        public string name { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public string summary { get; set; }

        public CodeSnippit(string name, string summary, string content)
        {
            this.name = name;

            this.summary = summary;
            this.content = content;
            author = "Empty author";
        }

        public override string ToString()
        {
            return $"{name} | {summary}";
        }
    }
}