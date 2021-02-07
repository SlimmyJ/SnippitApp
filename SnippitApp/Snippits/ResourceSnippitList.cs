using System;
using System.Collections.Generic;

namespace SnippitApp
{
    public class ResourceSnippitList : IObservable<List<CodeSnippit>>
    {
        public List<CodeSnippit> ObserverList;

        public IDisposable Subscribe(IObserver<List<CodeSnippit>> observer)
        {
            throw new NotImplementedException();
        }
    }
}