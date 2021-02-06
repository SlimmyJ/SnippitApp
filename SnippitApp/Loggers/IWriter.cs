using System.Collections.Generic;

namespace SnippitApp
{
    public interface IWriter
    {
        void WriteTo(List<CodeSnippit> thelist);
    }
}