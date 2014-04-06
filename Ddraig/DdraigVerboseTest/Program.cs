using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleManager;
using Scripting;

namespace DdraigVerboseTest
{
    class Program
    {
        CoreModuleManager m_module_manager;

        private Program()
        {
            m_module_manager = new CoreModuleManager();
            m_module_manager.RegisterModule(new Test.Test());
            m_module_manager.RegisterModule(new Scripting.Scripting());
            m_module_manager.ForceRefresh();
        }

        static void Main(string[] args)
        {
            Program pgm = new Program();
            while(Console.Read()!='x');
        }
    }
}
