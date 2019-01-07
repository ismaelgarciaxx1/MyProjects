using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordException
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            try
            {
                Console.WriteLine("enter new pass");
                password = Console.ReadLine();

                if (password.Length < 5)
                    throw new LessThanFive();
                
            }

            catch(LessThanFive ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
