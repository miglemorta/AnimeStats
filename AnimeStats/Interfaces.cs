using AnimeStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeStats
{
    public interface IStatsDataProvider
    {
        Task<IEnumerable<StatsAnime>> GetTopAnime(string subtypeAnime);
        
        Task<IEnumerable<StatsManga>> GetTopManga(string subtypeManga);

        Task<IEnumerable<StatsChar>> GetTopCharacters();

    }
}
