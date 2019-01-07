using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Desktop
    {
        public Monitor thisMonitor { get; set; } //thisMonitor is the monitor that is going to go with this Desktop Class (Composition).

        public Desktop( Monitor myBundledMonitor)
        {
            thisMonitor = myBundledMonitor;

        }
    }
}
