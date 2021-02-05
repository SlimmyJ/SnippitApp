using System.Collections.Generic;

using System.IO;
using System.Text.Json;

namespace SnippitApp
{
    public class SnippitRepo
    {
        private static List<CodeSnippit> _snippitListRepo;
        public JsonReader jasonbro;
        public JsonWriter jasonsis;

        //GET op basis van ID
        //public CodeSnippit GetSnippit(int id)
        //{
        //    //List<CodeSnippit> allSnippits = GetSnippits();
        //    var selectedSnippit = _snippitListRepo.Where(x => x.SnipID == id).FirstOrDefault();

        //    return selectedSnippit;
        //}

        //GET op basis van index

        public List<CodeSnippit> GetSnippits()
        {
            jasonbro = new JsonReader();
            jasonbro.GetSnippitListFromJson();
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