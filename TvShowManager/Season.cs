using System.Collections.Generic;
using System.Diagnostics;

namespace TvShowManager
{
    [DebuggerDisplay("Season {Number} of '{ShowName}'")]
    public class Season
    {
        public string ShowName { get; set; }
        public int Number { get; set; }
        public IEnumerable<Episode> Episodes { get; set; }
    }
}
