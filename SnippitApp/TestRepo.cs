using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippitApp
{
    class TestRepo : IObservable<List<CodeinSnippit>>
    {
        public IDisposable Subscribe(IObserver<List<CodeinSnippit>> observer)
        {
            throw new NotImplementedException();
        }
    }
}
