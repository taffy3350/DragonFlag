using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Module
{
    public interface IModule
    {
        string Name { get; }
        IEnumerable<String> Dependencies { get; }
        void ResolveDependency(IModule Module);
    }
}
