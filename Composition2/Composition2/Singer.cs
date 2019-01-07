using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition2
{
    class Singer
    {
        public Singer (string mPerformerName , string myRecordLabel)
        {
            performerName = mPerformerName;
            recordLabel = myRecordLabel;
        }
        public string performerName { get; set; }
        
        public string recordLabel { get; set; }

        public override string ToString()
        {
            return "singer Info: " + "\n" + performerName + "\n" + recordLabel + "\n" ;
        }
    }
}
