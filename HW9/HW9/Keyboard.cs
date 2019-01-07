using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9
{
    class Keyboard
    {
        public Keyboard(string myKeyboardName, double myKeyboardSku, double myKeyboardPrice)
        {
            keyboardName = myKeyboardName;
            keyboardSku = myKeyboardSku;
            keyboardPrice = myKeyboardPrice;

        }

        public string keyboardName { get; set; }
        public double keyboardSku { get; set; }
        public double keyboardPrice { get; set; }

        public override string ToString()
        {
            return "Ipad Keyboard Info" + "\n" + keyboardName + "\n" + keyboardSku + "\n" + keyboardPrice;

        }
    }
}
