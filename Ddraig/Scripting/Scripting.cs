using Common.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripting
{
    public class Scripting : IModule
    {

        public Scripting()
        {
            
        }

        public void init()
        {
            //setup required dependencies. If these aren't set up here
            //then they won't be requested
        }

        public string Name
        {
            get { return "Scripting"; }
        }
        
        private List<String> m_dependency_names = new List<String>();
        private List<IModule> m_dependencies = new List<IModule>();
        
        public IEnumerable<String> Dependencies
        {
            get { return (m_dependency_names); }
        }

        public void ResolveDependency(IModule Module)
        {
            m_dependencies.Add(Module);
        }
    }
}
