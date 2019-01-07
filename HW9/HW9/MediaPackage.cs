using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class MediaPackage
    {
        public MediaPackage(double mediaSku, double mediaPrice, Ipad MIpad, Speaker MSpeaker, Keyboard MKeyboard)
        {
            MediaSku = mediaSku;
            MediaPrice = mediaPrice;
            MediaIpad = MIpad;
            MediaSpeaker =MSpeaker;
            MediaKeyboard =MKeyboard;
        }

        public double MediaSku { get; set; }
        public double MediaPrice { get; set; }

        public  Ipad MediaIpad { get; set; }
        public Speaker MediaSpeaker { get; set; }
        public Keyboard MediaKeyboard { get; set; }

        public override string ToString()
        {
            return string.Format("Holiday Package "+"\n"+"SKU: " + MediaSku + "\n" + "Price: "+ MediaPrice + "\n" +"\n"+ "\n" + MediaIpad +"\n"+ "\n"+ MediaSpeaker + "\n" +"\n" + MediaKeyboard);
        }
    }
}
