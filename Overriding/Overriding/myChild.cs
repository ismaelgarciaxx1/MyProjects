using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class MyChild : MyParent
    {
        public override void MethodOne()
        {
            Console.WriteLine("This is from child class method");
            Console.ReadLine();
            base.MethodOne();
        }
    }
}
