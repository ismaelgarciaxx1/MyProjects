using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaHW9
{
    class Customer:Person
    {
        bool customerMailingList;
        //Constructor

        public Customer(bool m, string name, string address, string phoneNumber)
            : base(name, address, phoneNumber)
        {
            
            CustomerMailingList = m;
        }

        public bool CustomerMailingList
        {
            get
            {
                return customerMailingList;
            }

            set
            {
                customerMailingList = value;
            }
        }
    }
}
