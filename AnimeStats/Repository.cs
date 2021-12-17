using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimeStats;
using AnimeStats.Models;

namespace AnimeStats
{
    
    public class Repository
    {
        
        // count manga with volume <= x and members >= y
        public int CountMangaWithVolMembers(IEnumerable<StatsManga> res, int? vol, int mem)
        {
            return res.Where(book => book.volumes <= vol && book.members >= mem).Count();
        }
        
        // count finished anime (end_date != null) with scores > x
        public int CountFinishedAnimeWithScores(IEnumerable<StatsAnime> res, decimal scores)
        {
            return res.Where(show => !String.IsNullOrEmpty(show.end_date) && show.score >= scores).Count();
        }

        // count characters whose names start with the letter x
        public int CountCharNamesStartingWith(IEnumerable<StatsChar> res, string letter)
        {
            return res.Where(chars => chars.title.StartsWith(letter, StringComparison.InvariantCultureIgnoreCase)).Count();
        }

        // count how many of the top x popular anime are in the best rated anime top y
        public int CountHowManyPopAnimeInTopRated(IEnumerable<StatsAnime> resRating, IEnumerable<StatsAnime> resPop, int topRankRating, int topRankPop)
        {
            int number = 0;
            foreach (var pop in resPop.Where(show => show.rank <= topRankPop))
            {
                foreach(var rate in resRating.Where(show => show.rank <= topRankRating))
                {
                    if(pop.mal_id == rate.mal_id)
                    {
                        number++;
                    }
                }
            }
            return number;
        }
        
    }
}
