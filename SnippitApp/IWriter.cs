using System.Collections.Generic;

namespace SnippitApp
{
    public interface IWriter
    {
        void ToJson(List<CodeSnippit> thelist);
    }
}