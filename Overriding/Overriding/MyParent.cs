using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
   public class MyParent
    {
        public virtual void MethodOne()
        {
            Console.WriteLine("This is from the parent class");
            Console.ReadLine();


        }
    }
}
