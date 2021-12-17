using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimeStats;
using AnimeStats.Models;

namespace WindowsFormsAppAnimeStats
{
    public partial class Form1 : Form
    {

        private readonly IStatsDataProvider provider = new StatsDataProvider();
        IEnumerable<StatsAnime> resultsA;
        IEnumerable<StatsAnime> resultsApop;
        IEnumerable<StatsManga> resultsM;
        IEnumerable<StatsChar> resultsC;

        public Form1()
        {
            InitializeComponent();

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            resultsA = await provider.GetTopAnime("tv");// by rating
            foreach (var res in resultsA)
            {
                ListViewItem item = new ListViewItem(res.rank.ToString(), 0);
                item.SubItems.Add(res.title);
                item.SubItems.Add(res.episodes.ToString());
                item.SubItems.Add(res.start_date);
                item.SubItems.Add(res.end_date);
                item.SubItems.Add(res.members.ToString());
                item.SubItems.Add(res.score.ToString());
                listView1AnimeRating.Items.Add(item);
            }

            resultsApop = await provider.GetTopAnime("bypopularity");// by popularity
            foreach (var res in resultsApop)
            {
                ListViewItem item = new ListViewItem(res.rank.ToString(), 0);
                item.SubItems.Add(res.title);
                item.SubItems.Add(res.episodes.ToString());
                item.SubItems.Add(res.start_date);
                item.SubItems.Add(res.end_date);
                item.SubItems.Add(res.members.ToString());
                item.SubItems.Add(res.score.ToString());
                listView4AnimePop.Items.Add(item);
            }

            resultsM = await provider.GetTopManga("manga");// by rating
            foreach (var res in resultsM)
            {
                ListViewItem item = new ListViewItem(res.rank.ToString(), 0);
                item.SubItems.Add(res.title);
                item.SubItems.Add(res.volumes.ToString());
                item.SubItems.Add(res.start_date);
                item.SubItems.Add(res.end_date);
                item.SubItems.Add(res.members.ToString());
                item.SubItems.Add(res.score.ToString());
                listView2MangaRating.Items.Add(item);
            }

            resultsC = await provider.GetTopCharacters();
            foreach (var res in resultsC)
            {
                ListViewItem item = new ListViewItem(res.rank.ToString(), 0);
                item.SubItems.Add(res.title);
                listView3Characters.Items.Add(item);
            }

        }

        private void ButtonCountChar_Click(object sender, EventArgs e)
        {
            listViewAnswerChar.Items.Clear();
            var repository = new Repository();
            ListViewItem item = new ListViewItem(repository.CountCharNamesStartingWith(resultsC, textBox1Char.Text).ToString(), 0);
            listViewAnswerChar.Items.Add(item);
        }

        private void ButtonFinished_Click(object sender, EventArgs e)
        {
            listViewAnswerFinished.Items.Clear();
            var repository = new Repository();
            ListViewItem item = new ListViewItem(repository.CountFinishedAnimeWithScores(resultsA, Convert.ToDecimal(textBoxFinished.Text)).ToString(), 0);
            listViewAnswerFinished.Items.Add(item);

        }

        private void ButtonManga_Click(object sender, EventArgs e)
        {
            listViewAnswerManga.Items.Clear();
            var repository = new Repository();
            ListViewItem item = new ListViewItem(repository.CountMangaWithVolMembers(resultsM, Convert.ToInt32(textBoxVol.Text), Convert.ToInt32(textBoxMem.Text)).ToString(), 0);
            listViewAnswerManga.Items.Add(item);

        }

        private void ButtonPopRated_Click(object sender, EventArgs e)
        {
            listViewAnswerPopRated.Items.Clear();
            var repository = new Repository();
            ListViewItem item = new ListViewItem(repository.CountHowManyPopAnimeInTopRated(resultsA, resultsApop, Convert.ToInt32(textBoxTopRated.Text), Convert.ToInt32(textBoxTopPop.Text)).ToString(), 0);
            listViewAnswerPopRated.Items.Add(item);

        }
    }
}
