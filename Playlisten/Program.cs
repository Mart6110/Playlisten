using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new object, I call playlist
            Playlist playlist = new Playlist();

            // Adds the track to the playlist
            playlist.AddTrack("How to save a life");
            playlist.AddTrack("Mr. Sandman");

            // Adds the track to the top of the linked list
            playlist.AddTrackAtTop("Back in black");

            // Looping through the linked list and write out the list.
            foreach(Track t in playlist.playlist)
            {
                Console.WriteLine(t.TrackName);
            }

            Console.ReadLine();
        }
    }
}
