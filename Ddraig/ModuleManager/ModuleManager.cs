using Common.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleManager
{
    public class CoreModuleManager
    {
        private List<Common.Module.IModule> m_modules;

        public CoreModuleManager()
        {
            init();
        }

        public int RegisterModule(IModule Module)
        {
            resolve_dependencies( Module );
            m_modules.Add(Module);
            return ModuleReturnTypes.FINE;
        }

        public void ForceRefresh()
        {
            foreach (IModule mod in m_modules)
            {
                resolve_dependencies(mod);
            }
        }

        private void resolve_dependencies(IModule Module)
        {
            System.Console.Out.WriteLine("Resolving " + Module.Dependencies.ToList<String>().Count + " for " + Module.Name);
            foreach (String mod in Module.Dependencies)
            {
                bool resolved = false;
                foreach (IModule dep in m_modules)
                {
                    if (dep.Name == mod)
                    {
                        Module.ResolveDependency(dep);
                        resolved = true;
                    }
                }
                if (resolved)
                {
                    System.Console.Out.WriteLine("Dependency Resolved - " + mod);
                }
                else
                {
                    System.Console.Out.WriteLine("Dependency Unresolved - " + mod);
                }
            }            
        }
        
        private void init()
        {
            m_modules = new List<IModule>();
        }
    }
}
