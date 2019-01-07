using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipad i = new Ipad("IPod", 111,899);
            Speaker s = new Speaker("Pill", 333, 89.99);
            Keyboard k = new Keyboard("IKeyboard", 444, 79.99);

            MediaPackage m = new MediaPackage(555, 1100.99, i, s, k);

            Console.WriteLine(m);
            
            Console.ReadLine();
        }

        private static Ipad GetI()
        {
            return new Ipad("Ipod", myIpadSku: 222, myIpadPrice: 999.99);
        }
    }
}
