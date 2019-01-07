using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Example
    {
        public Example() // takes in Zero Parameter
        {
            Console.WriteLine("First Constructor Example");
            Console.ReadLine();
            Console.Clear();

        }


        public Example(int a, int b) // overloaded constructo 1 that takes in 2 int parameters
        {
            int result = a + b;

            Console.WriteLine("The 2st overloaded constructor result is " + result);
            Console.ReadLine();
            Console.Clear();

        }


        public Example(string a , string b) // 2nd overloaded constructor that takes in 2 string parameters
        {

            string result = a + " " + b;

            Console.WriteLine("This is the 2nd constructor result is " + result);
            Console.ReadLine();
            Console.Clear();

        }
    }
}
