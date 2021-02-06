using System.Collections.Generic;

namespace SnippitApp
{
    public interface IReader
    {
        string _jsonString { get; }

        List<CodeSnippit> GetSnippitListFromJson();
    }
}