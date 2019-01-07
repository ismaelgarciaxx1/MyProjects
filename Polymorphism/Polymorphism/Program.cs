using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP Polymorphism - Same method that can do multiple things C# text (overloading Methods)


            Example one = new Example();
            Example two = new Example(100,50);
            Example three = new Example("Jane", "Doe");
        }
    }
}
