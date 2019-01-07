using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            MyParent parent = new MyParent();
            parent.MethodOne();

            MyChild child = new MyChild();
            child.MethodOne();

        }
    }
}
