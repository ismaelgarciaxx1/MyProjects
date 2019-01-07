using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {     //page 277 and 321
        static void Main(string[] args)
        {
            int numOne , numTwo;

            Console.WriteLine("Input number one ");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number two ");
            numTwo = Convert.ToInt32(Console.ReadLine());


            Calculator myCalc = new Calculator();

            int answer = myCalc.Sum(numOne , numTwo);
            Console.WriteLine("the sum of first number and the second number equals  " + answer);
            Console.ReadLine();

        }
    }
}
