using System;
using System.Diagnostics;

namespace TvShowManager
{
    [DebuggerDisplay("{Season.Number}x{Number}: {Name}")]
    public class Episode
    {
        public Season Season { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime FirstAired { get; set; }
    }
}
