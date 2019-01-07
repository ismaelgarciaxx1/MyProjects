using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition2
{
    class Playlist
    {

        public Playlist(int myPlaylistNo, int myPlaylistSongNo, Singer mySinger, Song mySong)
        {
            playlistNo = myPlaylistNo;
            playlistSongNo = myPlaylistSongNo;
            plSinger = mySinger;
            plSong = mySong;

        }




        public int playlistNo { get; set; }
        public int playlistSongNo { get; set; }

        public Singer plSinger { get; set; }
        public Song plSong { get; set;  }

        public override string ToString()
        {
            return string.Format(plSinger + "\n" + plSong + "\n" + "\n" + "Playlist#" + "\n" + playlistNo);
        }

    }
}
