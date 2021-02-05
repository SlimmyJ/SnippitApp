using System.Collections.Generic;

namespace SnippitApp
{
    internal class SnippitRepo
    {
        private static List<CodeSnippit> _snippitListRepo;
        private static SnippitRepo _repo;
        private JsonReader _jasonBro;

        public static SnippitRepo GetSnippetRepo()
        {
            if (_repo == null)
            {
                _repo = new SnippitRepo();
            }
            return _repo;
        }

        //GET op basis van ID
        //public CodeSnippit GetSnippit(int id)
        //{
        //    //List<CodeSnippit> allSnippits = GetSnippits();
        //    var selectedSnippit = _snippitListRepo.Where(x => x.SnipID == id).FirstOrDefault();

        //    return selectedSnippit;
        //}

        //GET op basis van index
        public CodeSnippit GetSnippit(int index)
        {
            CodeSnippit[] allSnippits = GetSnippits().ToArray();

            return allSnippits[index];
        }

        public List<CodeSnippit> GetSnippits()
        {
            if (_snippitListRepo == null)
            {
                _snippitListRepo = GenerateExampleSnippits();
            }

            return _snippitListRepo;
        }

        public void AddSnippitToRepo(CodeSnippit snippit)
        {
            _snippitListRepo.Add(snippit);
        }

        public void RemoveSnippitFromRepo(CodeSnippit snippit)
        {
            _snippitListRepo.Remove(snippit);
        }

        public void RemoveSnippitFromRepo(int index)
        {
            _snippitListRepo.RemoveAt(index);
        }

        private List<CodeSnippit> GenerateExampleSnippits()
        {
            List<CodeSnippit> snippitlistrepo = new List<CodeSnippit>();

            snippitlistrepo.Add(new CodeSnippit("ThisSnippit", "You", "Summary", "Content"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit2", "You2", "Summary2", "Content2"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit3", "You3", "Summary3", "Content3"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit4", "You4", "Summary4", "Content4"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit5", "You5", "Summary5", "Content5"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit6", "You6", "Summary6", "Content6"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit7", "You7", "Summary7", "Content7"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit8", "You8", "Summary8", "Content8"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit9", "You9", "Summary9", "Content9"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit10", "You10", "Summary10", "Content10"));
            snippitlistrepo.Add(new CodeSnippit("ThisSnippit11", "You11", "Summary11", "Content11"));

            return snippitlistrepo;
        }
    }
}