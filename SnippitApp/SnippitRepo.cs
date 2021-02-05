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
            JsonReader jsonbro = new JsonReader();

            if (_snippitListRepo == null)
            {
                _snippitListRepo = jsonbro.GetSnippitListFromJson(@"C:\Users\simon\source\repos\SnippitApp\SnippitApp\bin\Debug\netcoreapp3.1\Testlist");
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
    }
}