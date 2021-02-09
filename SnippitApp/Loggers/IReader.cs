using SnippitApp.Snippits;
using System.Collections.Generic;

namespace SnippitApp.Loggers
{
    public interface IReader
    {
        string JsonString { get; }

        List<CodeSnippit> GetSnippitList();
    }
}