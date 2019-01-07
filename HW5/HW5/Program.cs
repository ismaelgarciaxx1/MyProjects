using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            double price = 0;
            double amount;

            Console.WriteLine("Don't Be Hungry, Get a Snack!");

            try
            {
                Console.WriteLine("Choose Candy a = $1.50 OR b=  $0.50 OR c= $1.35");
                choice = Convert.ToString(Console.ReadLine());

                if (choice == "a")
                {
                  price = 1.50;
                }

                else if (choice == "b")
                {
                    price = .50;
                }
                
                else if (choice == "c")
                {
                    price = 1.35;
                }

                else
                {
                    Console.WriteLine("Choose From Selection ");
                }

            }

            catch (Exception ex)
            {
                
            }

            try
            {
                Console.WriteLine("Put Amount of Money");
                amount = Convert.ToDouble(Console.ReadLine());

                if (amount > price)
                {
                    double result = amount - price;

                    Console.WriteLine("Your Change is " + result);
                }

                else if (amount < price)
                {
                    double result = amount - price;

                    Console.WriteLine("You Owe" + result);
                }

                else if (amount == price)
                {
                    Console.WriteLine("Enjoy Your Candy");
                }
                
            }



            catch (Exception ex)
            {

            }


            Console.ReadLine();


        }



    }
}
