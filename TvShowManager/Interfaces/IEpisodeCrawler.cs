using System.Threading.Tasks;

namespace TvShowManager.Interfaces
{
    public interface IEpisodeCrawler
    {
        Task<EpisodeList> DownloadEpisodeListAsync(string showName);
    }
}
