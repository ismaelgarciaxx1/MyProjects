using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition2
{
    class Song
    {

        public Song(string mySongName, string mySongAlbum, double mySongLength, int mySongYers)
        {
            songName = mySongName;
            songAlbum = mySongAlbum;
            songLength = mySongLength;
            songYear = mySongYers;
        }

        public string songName { get; set; }

        public string songAlbum { get; set; }

        public double songLength { get; set; }

        public int songYear { get; set; }

        public override string ToString()
        {
            return "Song Info:" + "\n" + songName + "\n" + songAlbum + "\n" + songLength +"\n" + songYear + "\n" ;
        }


    }
}
