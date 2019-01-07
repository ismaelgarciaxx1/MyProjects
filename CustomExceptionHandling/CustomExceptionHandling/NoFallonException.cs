using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandling
{
   public class NoFallonException : Exception
    {
        public NoFallonException() : base ("Jimmy Fallon is not funny")
        {
            Console.WriteLine("Conan O'Brien is the only choice");
        }
    }
}
