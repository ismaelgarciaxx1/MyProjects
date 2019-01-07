using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("Enter a menu Selection number(0 - 1)");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("Do something for choice ZERO");
                    break;

                case 1:
                    Console.WriteLine("Do something for choice ONE");

                break;

                default:

                    Console.WriteLine("This block will be executed if none of the above switches was chosen by user");
                break;
                    
            
            }

            Console.ReadLine();

        }
    }
}
