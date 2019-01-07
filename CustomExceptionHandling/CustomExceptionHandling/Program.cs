using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string aName;
            
           

            try
            {
                aName = GetName();
                Console.WriteLine("Hello " + aName);

               

            }

            catch (NoFallonException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }


            
        }


        public static string GetName()
        {
            Console.WriteLine("Enter your fav late night TV host");

            string name = Console.ReadLine();

            if (name.Equals("Jimmy Fallon"))
                throw new NoFallonException();

            return name;


        }
    }
}
