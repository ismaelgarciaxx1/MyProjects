using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaHW9
{
    class Person
    {
        // Fields
        private string _name;
        private string _address;
        private string _phoneNumber;

        public string name
        {
            // name property
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string address
        {
            // address property
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public string phoneNumbers
        {
            // phone numbers property
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public Person(string name, string address, string phoneNumber)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
        }
    }
}
