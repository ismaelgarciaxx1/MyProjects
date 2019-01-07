using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Speaker
    {
        public Speaker(string mySpeakerName, double mySpeakerSku, double mySpeakerPrice)
        {
            speakerName = mySpeakerName;
            speakerSku = mySpeakerSku;
            speakerPrice = mySpeakerPrice;

        }

        public string speakerName { get; set; }
        public double speakerSku { get; set; }
        public double speakerPrice { get; set; }

        public override string ToString()
        {
            return string.Format("Beats Bluetooth Speaker Info" + "\n" + speakerName + "\n" + speakerSku + "\n" + speakerPrice);

        }
    }
}
