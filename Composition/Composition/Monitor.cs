using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Monitor
    {
        public int serialNum;

        public Monitor(int mySerialNum)
        {
            serialNum = mySerialNum;

        }

        public void DisplaySerialNum()
        {
            if (serialNum < 2000)
            {
                Console.WriteLine("This monitor serial number is "+ serialNum + " and it is the last years model");

                
                
            }
            else
            {
                Console.WriteLine("This monitor's serial number is " + serialNum + " and it's the latest model");
            }
        }
    }
}
