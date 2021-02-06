using System.Collections.Generic;

namespace SnippitApp
{
    public class SnippitRepo
    {
        public List<CodeSnippit> SnippitListRepo;
        public JsonReader Jasonbro;
        public JsonWriter Jasonsis;

        //GET op basis van ID
        //public CodeSnippit GetSnippit(int id)
        //{
        //    //List<CodeSnippit> allSnippits = GetSnippits();
        //    var selectedSnippit = _snippitListRepo.Where(x => x.SnipID == id).FirstOrDefault();

        //    return selectedSnippit;
        //}

        //GET op basis van index

        public SnippitRepo(JsonReader jasonbro, JsonWriter jasonsis)
        {
            Jasonbro = jasonbro;
            Jasonsis = jasonsis;
        }

        public List<CodeSnippit> GetSnippits()
        {
            Jasonbro = new JsonReader();
            Jasonbro.GetSnippitListFromJson();
            return SnippitListRepo;
        }

        public void AddSnippitToRepo(CodeSnippit snippit)
        {
            SnippitListRepo.Add(snippit);
        }

        public void RemoveSnippitFromRepo(CodeSnippit snippit)
        {
            SnippitListRepo.Remove(snippit);
        }

        public void RemoveSnippitFromRepo(int index)
        {
            SnippitListRepo.RemoveAt(index);
        }
    }
}