using Common.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Test : IModule 
    {

        public Test()
        {
            m_dependency_string.Add("Scripting");
        }

        string IModule.Name
        {
            get { return "Test"; }
        }
        
        private List<IModule> m_dependencies = new List<IModule>();
        private List<String> m_dependency_string = new List<String>();
        
        public IEnumerable<String> Dependencies
        {
            get { return m_dependency_string; }
        }

        public void ResolveDependency(IModule Module)
        {
            m_dependencies.Add(Module);
        }
    }
}
