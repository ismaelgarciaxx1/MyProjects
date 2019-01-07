using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Ipad
    {
        public Ipad(string myIpadName, double myIpadSku, double myIpadPrice)
        {
            ipadName=myIpadName;
            ipadSku=myIpadSku;
            ipadPrice =myIpadPrice;

        }

        public string ipadName {get; set;}
        public double ipadSku {get; set;}
        public double ipadPrice {get; set;}

        public override string ToString()
        {
            return "Ipad Info:" +"\n"+ ipadName + "\n" + ipadSku + "\n" + ipadPrice;
        
        }

    }
}
