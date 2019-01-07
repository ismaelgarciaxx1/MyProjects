using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            string food;
            Console.WriteLine("Enter From Menu (Snack - Appetizer - Meal - Desert)");
            food = Console.ReadLine().ToLower();

            switch (food)
            {


                case "snack":
                    Console.WriteLine("Cheetos");
                    break;

                case "appetizer":
                    Console.WriteLine("Chips and Salsa");
                    break;

                case "meal":
                    Console.WriteLine("Burger");
                    break;

                case "desert":
                    Console.WriteLine("cup cake");
                    break;


            }
            Console.ReadLine();
        }
    }
}
