using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor aMonitor = new Monitor(1875);


            Desktop aDesktop = new Desktop(aMonitor);

            aDesktop.thisMonitor.DisplaySerialNum();
            Console.ReadLine();
        }
    }
}
