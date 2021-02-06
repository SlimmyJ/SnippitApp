using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippitApp
{
    public abstract class Writer : IWriter
    {
        public void WriteTo(List<CodeSnippit> thelist)
        {
            throw new NotImplementedException();
        }
    }
}
