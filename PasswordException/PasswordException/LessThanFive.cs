using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordException
{
    public class LessThanFive : Exception
    {
        public LessThanFive() : base ("Need five Charactars")
        {
            Console.WriteLine("Need at least five");
        }
    }
}
