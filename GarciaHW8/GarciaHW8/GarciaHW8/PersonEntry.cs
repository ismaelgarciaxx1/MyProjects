using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarciaHW8
{
    class PersonEntry
    {
        // Fields
        private string _name;
        private string _email;
        private string _phoneNumber;

        public string name
        {
            // name property
            get { return _name; }
            set { _name = value; }
        }

        public string email
        {
            // email property
            get { return _email; }
            set { _email = value; }
        }

        public string phoneNumbers
        {
            // phone numbers property
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public PersonEntry(string name, string email, string phoneNumber)
        {
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
        }

    }
}
