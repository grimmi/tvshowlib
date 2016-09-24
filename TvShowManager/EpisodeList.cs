using System.Collections.Generic;

namespace TvShowManager
{
    public class EpisodeList
    {
        public string ShowName { get; set; }
        public IEnumerable<Season> Seasons { get; set; }

        public EpisodeList()
        {

        }
    }
}
