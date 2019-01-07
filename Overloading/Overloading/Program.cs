using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCal = new Calculator();
            myCal.Add(6, 8);
            myCal.Add(8.5556, 8);
            myCal.Add(65.999, 8.55555);

            Console.ReadLine();

        }
    }
}
