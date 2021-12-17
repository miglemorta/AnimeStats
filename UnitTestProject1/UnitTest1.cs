using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using AnimeStats;
using AnimeStats.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        readonly List<StatsAnime> listAnimeRating = new List<StatsAnime>
        {
            new StatsAnime {mal_id = 100, rank=1, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date="aug 2001", members=100000, score=9.2m },
            new StatsAnime {mal_id = 101, rank=2, title="abc", type="tv", episodes=null, start_date="jan 2000", end_date=null, members=100000, score=9.13m },
            new StatsAnime {mal_id = 102, rank=3, title="abc", type="tv", episodes=20, start_date="jan 2000", end_date="aug 2001", members=100000, score=8.72m },
            new StatsAnime {mal_id = 103, rank=4, title="abc", type="tv", episodes=12, start_date="jan 2000", end_date="aug 2001", members=100000, score=8.65m },
            new StatsAnime {mal_id = 104, rank=5, title="abc", type="tv", episodes=null, start_date="jan 2000", end_date=null, members=100000, score=8.4m },
            new StatsAnime {mal_id = 105, rank=6, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date="aug 2001", members=100000, score=8.01m },
            new StatsAnime {mal_id = 106, rank=7, title="abc", type="tv", episodes=70, start_date="jan 2000", end_date="aug 2001", members=100000, score=7.96m },
            new StatsAnime {mal_id = 107, rank=8, title="abc", type="tv", episodes=103, start_date="jan 2000", end_date="aug 2001", members=100000, score=7.9m },
        };
        readonly List<StatsAnime> listAnimePop = new List<StatsAnime>
        {
            new StatsAnime {mal_id = 203, rank=1, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date="aug 2001", members=100000, score=7.3m },
            new StatsAnime {mal_id = 100, rank=2, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date="aug 2001", members=100000, score=9.2m },
            new StatsAnime {mal_id = 348, rank=3, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date=null, members=100000, score=6.5m },
            new StatsAnime {mal_id = 120, rank=4, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date="aug 2001", members=100000, score=7.56m },
            new StatsAnime {mal_id = 105, rank=5, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date="aug 2001", members=100000, score=8.01m },
            new StatsAnime {mal_id = 102, rank=6, title="abc", type="tv", episodes=20, start_date="jan 2000", end_date="aug 2001", members=100000, score=8.72m },
            new StatsAnime {mal_id = 243, rank=7, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date=null, members=100000, score=7.8m },
            new StatsAnime {mal_id = 187, rank=8, title="abc", type="tv", episodes=50, start_date="jan 2000", end_date="aug 2001", members=100000, score=7.67m },
        };
        readonly List<StatsManga> listMangaRating = new List<StatsManga>
        {
            new StatsManga {mal_id = 201, rank=1, title="abc", type="manga", volumes=51, start_date="jan 2000", end_date="aug 2001", members=453618, score=8.3m },
            new StatsManga {mal_id = 202, rank=2, title="abc", type="manga", volumes=null, start_date="jan 2000", end_date=null, members=231584, score=8.3m },
            new StatsManga {mal_id = 203, rank=3, title="abc", type="manga", volumes=32, start_date="jan 2000", end_date="aug 2001", members=346810, score=8.3m },
            new StatsManga {mal_id = 204, rank=4, title="abc", type="manga", volumes=79, start_date="jan 2000", end_date="aug 2001", members=484149, score=8.3m },
            new StatsManga {mal_id = 205, rank=5, title="abc", type="manga", volumes=102, start_date="jan 2000", end_date="aug 2001", members=246951, score=8.3m },
            new StatsManga {mal_id = 206, rank=6, title="abc", type="manga", volumes=null, start_date="jan 2000", end_date=null, members=186749, score=8.3m },
            new StatsManga {mal_id = 207, rank=7, title="abc", type="manga", volumes=13, start_date="jan 2000", end_date="aug 2001", members=357954, score=8.3m },
            new StatsManga {mal_id = 208, rank=8, title="abc", type="manga", volumes=25, start_date="jan 2000", end_date="aug 2001", members=168129, score=8.3m },
        };
        readonly List<StatsChar> listChar = new List<StatsChar>
        {
            new StatsChar {mal_id = 300, rank=1, title="abc" },
            new StatsChar {mal_id = 301, rank=2, title="acd" },
            new StatsChar {mal_id = 302, rank=3, title="fgu" },
            new StatsChar {mal_id = 303, rank=4, title="edf" },
            new StatsChar {mal_id = 304, rank=5, title="ayt" },
            new StatsChar {mal_id = 305, rank=6, title="vfl" },
            new StatsChar {mal_id = 306, rank=7, title="ect" },
            new StatsChar {mal_id = 307, rank=8, title="qwe" },
        };

        [TestMethod]
        public void TestCountFinishedAnimeWithScores()
        {
            var repository = new Repository();

            Assert.AreEqual(4, repository.CountFinishedAnimeWithScores(listAnimeRating, 8));
            Assert.AreEqual(1, repository.CountFinishedAnimeWithScores(listAnimeRating, 9));
            Assert.AreEqual(6, repository.CountFinishedAnimeWithScores(listAnimeRating, 7));
        }

        [TestMethod]
        public void TestCountMangaWithVolMembers()
        {
            var repository = new Repository();

            Assert.AreEqual(2, repository.CountMangaWithVolMembers(listMangaRating, 40, 300000));
            Assert.AreEqual(2, repository.CountMangaWithVolMembers(listMangaRating, 100, 400000));
            Assert.AreEqual(4, repository.CountMangaWithVolMembers(listMangaRating, 70, 100000));
        }

        [TestMethod]
        public void TestCountCharNamesStartingWith()
        {
            var repository = new Repository();

            Assert.AreEqual(3, repository.CountCharNamesStartingWith(listChar, "a"));
            Assert.AreEqual(2, repository.CountCharNamesStartingWith(listChar, "e"));
            Assert.AreEqual(1, repository.CountCharNamesStartingWith(listChar, "v"));
        }

        [TestMethod]
        public void TestCountHowManyPopAnimeInTopRated()
        {
            var repository = new Repository();

            Assert.AreEqual(3, repository.CountHowManyPopAnimeInTopRated(listAnimeRating, listAnimePop, 8, 8));
            Assert.AreEqual(2, repository.CountHowManyPopAnimeInTopRated(listAnimeRating, listAnimePop, 5, 7));
            Assert.AreEqual(1, repository.CountHowManyPopAnimeInTopRated(listAnimeRating, listAnimePop, 3, 4));
        }
    }
}
