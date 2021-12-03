using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class FacadeMain
    {
        public void Run()
        {
            WordsFacade.Save();
            WordsFacade.Load();
        }
    }
}
