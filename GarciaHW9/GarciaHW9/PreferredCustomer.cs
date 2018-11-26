using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaHW9
{
    class PreferredCustomer : Customer
    {
        double customerAmount;
        double customerDiscount;

        // constructor

        public PreferredCustomer(bool m, string name, string address, string phoneNumber)
             : base(m, name, address, phoneNumber)
        {
           
        }

       



        //bool test
        public void setcustAmount(double amount)
        {
            customerAmount = amount;

            if (customerAmount < 500)
            {
                customerDiscount = 0;
            }

            else if (customerAmount < 1000)
            {
                customerDiscount = 5;
            }

            else if (customerAmount < 1500)
            {
                customerDiscount = 6;
            }

            else if (customerAmount < 2000)
            {
                customerDiscount = 7;
            }

            else
            {
                customerDiscount = 10;
                
            }
                

        }
        public double getDiscount()
        {
            return customerDiscount;
        }


    }
}
