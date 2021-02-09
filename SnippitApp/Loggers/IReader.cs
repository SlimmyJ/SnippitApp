using System.Collections.Generic;

namespace SnippitApp.Loggers
{
    public interface IReader
    {
        string _jsonString { get; }

        List<CodeSnippit> GetSnippitList();
    }
}