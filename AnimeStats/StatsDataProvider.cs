using AnimeStats.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AnimeStats
{
    public class StatsDataProvider : IStatsDataProvider
    {
        private readonly HttpClient httpClient;

        public StatsDataProvider()
        {
            var baseAddress = new Uri("https://api.jikan.moe/v3/top/");
            httpClient = new HttpClient { BaseAddress = baseAddress };
        }

        public async Task<IEnumerable<StatsAnime>> GetTopAnime(string subtypeAnime)
        {
            try
            {
                using (var response = await httpClient.GetAsync($"anime/1/{subtypeAnime}"))
                {

                    var responseData = await response.Content.ReadAsStringAsync();

                    JObject s = JObject.Parse(responseData);
                    var top = s["top"];

                    return top.ToObject<IEnumerable<StatsAnime>>();
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
                return null;
            }
        }

        public async Task<IEnumerable<StatsManga>> GetTopManga(string subtypeManga)
        {
            try
            {
                using (var response = await httpClient.GetAsync($"manga/1/{subtypeManga}"))
                {
                    var responseData = await response.Content.ReadAsStringAsync();

                    JObject s = JObject.Parse(responseData);
                    var top = s["top"];

                    return top.ToObject<IEnumerable<StatsManga>>();
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
                return null;
            }
        }
        
        public async Task<IEnumerable<StatsChar>> GetTopCharacters()
        {
            try
            {
                using (var response = await httpClient.GetAsync($"characters/1"))
                {
                    var responseData = await response.Content.ReadAsStringAsync();

                    JObject s = JObject.Parse(responseData);
                    var top = s["top"];

                    return top.ToObject<IEnumerable<StatsChar>>();
                }
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
                return null;
            }
        }
        
    }
}
