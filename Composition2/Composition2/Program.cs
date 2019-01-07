using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer singer1 = new Singer("Journey", "Columbia");
            Song song01 = new Song("Don't Stop Believing", "Escape", 4.11, 1981);

            Playlist playlist1 = new Playlist(1, 1, singer1, song01);
            Console.WriteLine(playlist1);
            Console.ReadLine();

        }
    }
}
