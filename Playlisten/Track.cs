using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    class Track
    {
        // instance variables
        private string trackName;
        public string TrackName { get { return trackName; } }

        // Constructor
        public Track(string trackName)
        {
            this.trackName = trackName;
        }
    }
}
