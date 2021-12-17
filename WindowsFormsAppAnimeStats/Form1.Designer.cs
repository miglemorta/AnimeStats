
namespace WindowsFormsAppAnimeStats
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAnimeRating = new System.Windows.Forms.TabPage();
            this.listView1AnimeRating = new System.Windows.Forms.ListView();
            this.columnHeader1rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3episodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4start = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5end = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6members = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabManga = new System.Windows.Forms.TabPage();
            this.listView2MangaRating = new System.Windows.Forms.ListView();
            this.columnHeader1rankM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1titleM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1vol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1startM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1endM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1memM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1scoreM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCharacters = new System.Windows.Forms.TabPage();
            this.listView3Characters = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAnimePop = new System.Windows.Forms.TabPage();
            this.listView4AnimePop = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCount = new System.Windows.Forms.TabPage();
            this.listViewAnswerPopRated = new System.Windows.Forms.ListView();
            this.buttonPopRated = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTopRated = new System.Windows.Forms.TextBox();
            this.textBoxTopPop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewAnswerManga = new System.Windows.Forms.ListView();
            this.listViewAnswerFinished = new System.Windows.Forms.ListView();
            this.buttonFinished = new System.Windows.Forms.Button();
            this.buttonManga = new System.Windows.Forms.Button();
            this.textBoxFinished = new System.Windows.Forms.TextBox();
            this.textBoxMem = new System.Windows.Forms.TextBox();
            this.labelMembers = new System.Windows.Forms.Label();
            this.textBoxVol = new System.Windows.Forms.TextBox();
            this.listViewAnswerChar = new System.Windows.Forms.ListView();
            this.buttonCountChar = new System.Windows.Forms.Button();
            this.textBox1Char = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1countManga = new System.Windows.Forms.Label();
            this.label1finishedAni = new System.Windows.Forms.Label();
            this.listView5Count = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabAnimeRating.SuspendLayout();
            this.tabManga.SuspendLayout();
            this.tabCharacters.SuspendLayout();
            this.tabAnimePop.SuspendLayout();
            this.tabCount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabAnimeRating);
            this.tabControl1.Controls.Add(this.tabManga);
            this.tabControl1.Controls.Add(this.tabCharacters);
            this.tabControl1.Controls.Add(this.tabAnimePop);
            this.tabControl1.Controls.Add(this.tabCount);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabAnimeRating
            // 
            this.tabAnimeRating.Controls.Add(this.listView1AnimeRating);
            resources.ApplyResources(this.tabAnimeRating, "tabAnimeRating");
            this.tabAnimeRating.Name = "tabAnimeRating";
            this.tabAnimeRating.UseVisualStyleBackColor = true;
            // 
            // listView1AnimeRating
            // 
            resources.ApplyResources(this.listView1AnimeRating, "listView1AnimeRating");
            this.listView1AnimeRating.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1rank,
            this.columnHeader2title,
            this.columnHeader3episodes,
            this.columnHeader4start,
            this.columnHeader5end,
            this.columnHeader6members,
            this.columnHeader7score});
            this.listView1AnimeRating.HideSelection = false;
            this.listView1AnimeRating.Name = "listView1AnimeRating";
            this.listView1AnimeRating.UseCompatibleStateImageBehavior = false;
            this.listView1AnimeRating.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1rank
            // 
            resources.ApplyResources(this.columnHeader1rank, "columnHeader1rank");
            // 
            // columnHeader2title
            // 
            resources.ApplyResources(this.columnHeader2title, "columnHeader2title");
            // 
            // columnHeader3episodes
            // 
            resources.ApplyResources(this.columnHeader3episodes, "columnHeader3episodes");
            // 
            // columnHeader4start
            // 
            resources.ApplyResources(this.columnHeader4start, "columnHeader4start");
            // 
            // columnHeader5end
            // 
            resources.ApplyResources(this.columnHeader5end, "columnHeader5end");
            // 
            // columnHeader6members
            // 
            resources.ApplyResources(this.columnHeader6members, "columnHeader6members");
            // 
            // columnHeader7score
            // 
            resources.ApplyResources(this.columnHeader7score, "columnHeader7score");
            // 
            // tabManga
            // 
            this.tabManga.Controls.Add(this.listView2MangaRating);
            resources.ApplyResources(this.tabManga, "tabManga");
            this.tabManga.Name = "tabManga";
            this.tabManga.UseVisualStyleBackColor = true;
            // 
            // listView2MangaRating
            // 
            resources.ApplyResources(this.listView2MangaRating, "listView2MangaRating");
            this.listView2MangaRating.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1rankM,
            this.columnHeader1titleM,
            this.columnHeader1vol,
            this.columnHeader1startM,
            this.columnHeader1endM,
            this.columnHeader1memM,
            this.columnHeader1scoreM});
            this.listView2MangaRating.HideSelection = false;
            this.listView2MangaRating.Name = "listView2MangaRating";
            this.listView2MangaRating.UseCompatibleStateImageBehavior = false;
            this.listView2MangaRating.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1rankM
            // 
            resources.ApplyResources(this.columnHeader1rankM, "columnHeader1rankM");
            // 
            // columnHeader1titleM
            // 
            resources.ApplyResources(this.columnHeader1titleM, "columnHeader1titleM");
            // 
            // columnHeader1vol
            // 
            resources.ApplyResources(this.columnHeader1vol, "columnHeader1vol");
            // 
            // columnHeader1startM
            // 
            resources.ApplyResources(this.columnHeader1startM, "columnHeader1startM");
            // 
            // columnHeader1endM
            // 
            resources.ApplyResources(this.columnHeader1endM, "columnHeader1endM");
            // 
            // columnHeader1memM
            // 
            resources.ApplyResources(this.columnHeader1memM, "columnHeader1memM");
            // 
            // columnHeader1scoreM
            // 
            resources.ApplyResources(this.columnHeader1scoreM, "columnHeader1scoreM");
            // 
            // tabCharacters
            // 
            this.tabCharacters.Controls.Add(this.listView3Characters);
            resources.ApplyResources(this.tabCharacters, "tabCharacters");
            this.tabCharacters.Name = "tabCharacters";
            this.tabCharacters.UseVisualStyleBackColor = true;
            // 
            // listView3Characters
            // 
            resources.ApplyResources(this.listView3Characters, "listView3Characters");
            this.listView3Characters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView3Characters.HideSelection = false;
            this.listView3Characters.Name = "listView3Characters";
            this.listView3Characters.UseCompatibleStateImageBehavior = false;
            this.listView3Characters.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // tabAnimePop
            // 
            this.tabAnimePop.Controls.Add(this.listView4AnimePop);
            resources.ApplyResources(this.tabAnimePop, "tabAnimePop");
            this.tabAnimePop.Name = "tabAnimePop";
            this.tabAnimePop.UseVisualStyleBackColor = true;
            // 
            // listView4AnimePop
            // 
            resources.ApplyResources(this.listView4AnimePop, "listView4AnimePop");
            this.listView4AnimePop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView4AnimePop.HideSelection = false;
            this.listView4AnimePop.Name = "listView4AnimePop";
            this.listView4AnimePop.UseCompatibleStateImageBehavior = false;
            this.listView4AnimePop.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // tabCount
            // 
            this.tabCount.Controls.Add(this.listViewAnswerPopRated);
            this.tabCount.Controls.Add(this.buttonPopRated);
            this.tabCount.Controls.Add(this.label4);
            this.tabCount.Controls.Add(this.textBoxTopRated);
            this.tabCount.Controls.Add(this.textBoxTopPop);
            this.tabCount.Controls.Add(this.label1);
            this.tabCount.Controls.Add(this.listViewAnswerManga);
            this.tabCount.Controls.Add(this.listViewAnswerFinished);
            this.tabCount.Controls.Add(this.buttonFinished);
            this.tabCount.Controls.Add(this.buttonManga);
            this.tabCount.Controls.Add(this.textBoxFinished);
            this.tabCount.Controls.Add(this.textBoxMem);
            this.tabCount.Controls.Add(this.labelMembers);
            this.tabCount.Controls.Add(this.textBoxVol);
            this.tabCount.Controls.Add(this.listViewAnswerChar);
            this.tabCount.Controls.Add(this.buttonCountChar);
            this.tabCount.Controls.Add(this.textBox1Char);
            this.tabCount.Controls.Add(this.label3);
            this.tabCount.Controls.Add(this.label2);
            this.tabCount.Controls.Add(this.label1countManga);
            this.tabCount.Controls.Add(this.label1finishedAni);
            this.tabCount.Controls.Add(this.listView5Count);
            resources.ApplyResources(this.tabCount, "tabCount");
            this.tabCount.Name = "tabCount";
            this.tabCount.UseVisualStyleBackColor = true;
            // 
            // listViewAnswerPopRated
            // 
            this.listViewAnswerPopRated.HideSelection = false;
            resources.ApplyResources(this.listViewAnswerPopRated, "listViewAnswerPopRated");
            this.listViewAnswerPopRated.Name = "listViewAnswerPopRated";
            this.listViewAnswerPopRated.UseCompatibleStateImageBehavior = false;
            this.listViewAnswerPopRated.View = System.Windows.Forms.View.List;
            // 
            // buttonPopRated
            // 
            resources.ApplyResources(this.buttonPopRated, "buttonPopRated");
            this.buttonPopRated.Name = "buttonPopRated";
            this.buttonPopRated.UseVisualStyleBackColor = true;
            this.buttonPopRated.Click += new System.EventHandler(this.ButtonPopRated_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxTopRated
            // 
            resources.ApplyResources(this.textBoxTopRated, "textBoxTopRated");
            this.textBoxTopRated.Name = "textBoxTopRated";
            // 
            // textBoxTopPop
            // 
            resources.ApplyResources(this.textBoxTopPop, "textBoxTopPop");
            this.textBoxTopPop.Name = "textBoxTopPop";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // listViewAnswerManga
            // 
            this.listViewAnswerManga.HideSelection = false;
            resources.ApplyResources(this.listViewAnswerManga, "listViewAnswerManga");
            this.listViewAnswerManga.Name = "listViewAnswerManga";
            this.listViewAnswerManga.UseCompatibleStateImageBehavior = false;
            this.listViewAnswerManga.View = System.Windows.Forms.View.List;
            // 
            // listViewAnswerFinished
            // 
            this.listViewAnswerFinished.HideSelection = false;
            resources.ApplyResources(this.listViewAnswerFinished, "listViewAnswerFinished");
            this.listViewAnswerFinished.Name = "listViewAnswerFinished";
            this.listViewAnswerFinished.UseCompatibleStateImageBehavior = false;
            this.listViewAnswerFinished.View = System.Windows.Forms.View.List;
            // 
            // buttonFinished
            // 
            resources.ApplyResources(this.buttonFinished, "buttonFinished");
            this.buttonFinished.Name = "buttonFinished";
            this.buttonFinished.UseVisualStyleBackColor = true;
            this.buttonFinished.Click += new System.EventHandler(this.ButtonFinished_Click);
            // 
            // buttonManga
            // 
            resources.ApplyResources(this.buttonManga, "buttonManga");
            this.buttonManga.Name = "buttonManga";
            this.buttonManga.UseVisualStyleBackColor = true;
            this.buttonManga.Click += new System.EventHandler(this.ButtonManga_Click);
            // 
            // textBoxFinished
            // 
            resources.ApplyResources(this.textBoxFinished, "textBoxFinished");
            this.textBoxFinished.Name = "textBoxFinished";
            // 
            // textBoxMem
            // 
            resources.ApplyResources(this.textBoxMem, "textBoxMem");
            this.textBoxMem.Name = "textBoxMem";
            // 
            // labelMembers
            // 
            resources.ApplyResources(this.labelMembers, "labelMembers");
            this.labelMembers.Name = "labelMembers";
            // 
            // textBoxVol
            // 
            resources.ApplyResources(this.textBoxVol, "textBoxVol");
            this.textBoxVol.Name = "textBoxVol";
            // 
            // listViewAnswerChar
            // 
            this.listViewAnswerChar.HideSelection = false;
            resources.ApplyResources(this.listViewAnswerChar, "listViewAnswerChar");
            this.listViewAnswerChar.Name = "listViewAnswerChar";
            this.listViewAnswerChar.UseCompatibleStateImageBehavior = false;
            this.listViewAnswerChar.View = System.Windows.Forms.View.List;
            // 
            // buttonCountChar
            // 
            resources.ApplyResources(this.buttonCountChar, "buttonCountChar");
            this.buttonCountChar.Name = "buttonCountChar";
            this.buttonCountChar.UseVisualStyleBackColor = true;
            this.buttonCountChar.Click += new System.EventHandler(this.ButtonCountChar_Click);
            // 
            // textBox1Char
            // 
            resources.ApplyResources(this.textBox1Char, "textBox1Char");
            this.textBox1Char.Name = "textBox1Char";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1countManga
            // 
            resources.ApplyResources(this.label1countManga, "label1countManga");
            this.label1countManga.Name = "label1countManga";
            // 
            // label1finishedAni
            // 
            resources.ApplyResources(this.label1finishedAni, "label1finishedAni");
            this.label1finishedAni.Name = "label1finishedAni";
            // 
            // listView5Count
            // 
            resources.ApplyResources(this.listView5Count, "listView5Count");
            this.listView5Count.HideSelection = false;
            this.listView5Count.Name = "listView5Count";
            this.listView5Count.UseCompatibleStateImageBehavior = false;
            this.listView5Count.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Name = "panel1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAnimeRating.ResumeLayout(false);
            this.tabManga.ResumeLayout(false);
            this.tabCharacters.ResumeLayout(false);
            this.tabAnimePop.ResumeLayout(false);
            this.tabCount.ResumeLayout(false);
            this.tabCount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAnimeRating;
        private System.Windows.Forms.TabPage tabManga;
        private System.Windows.Forms.TabPage tabCharacters;
        private System.Windows.Forms.TabPage tabAnimePop;
        private System.Windows.Forms.TabPage tabCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1AnimeRating;
        private System.Windows.Forms.ListView listView2MangaRating;
        private System.Windows.Forms.ListView listView5Count;
        private System.Windows.Forms.ColumnHeader columnHeader1rank;
        private System.Windows.Forms.ColumnHeader columnHeader2title;
        private System.Windows.Forms.ColumnHeader columnHeader3episodes;
        private System.Windows.Forms.ColumnHeader columnHeader4start;
        private System.Windows.Forms.ColumnHeader columnHeader5end;
        private System.Windows.Forms.ColumnHeader columnHeader6members;
        private System.Windows.Forms.ColumnHeader columnHeader7score;
        private System.Windows.Forms.ColumnHeader columnHeader1rankM;
        private System.Windows.Forms.ColumnHeader columnHeader1titleM;
        private System.Windows.Forms.ColumnHeader columnHeader1vol;
        private System.Windows.Forms.ColumnHeader columnHeader1startM;
        private System.Windows.Forms.ColumnHeader columnHeader1endM;
        private System.Windows.Forms.ColumnHeader columnHeader1memM;
        private System.Windows.Forms.ColumnHeader columnHeader1scoreM;
        private System.Windows.Forms.ListView listView3Characters;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView4AnimePop;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1countManga;
        private System.Windows.Forms.Label label1finishedAni;
        private System.Windows.Forms.TextBox textBox1Char;
        private System.Windows.Forms.ListView listViewAnswerChar;
        private System.Windows.Forms.Button buttonCountChar;
        private System.Windows.Forms.ListView listViewAnswerManga;
        private System.Windows.Forms.ListView listViewAnswerFinished;
        private System.Windows.Forms.Button buttonFinished;
        private System.Windows.Forms.Button buttonManga;
        private System.Windows.Forms.TextBox textBoxFinished;
        private System.Windows.Forms.TextBox textBoxMem;
        private System.Windows.Forms.Label labelMembers;
        private System.Windows.Forms.TextBox textBoxVol;
        private System.Windows.Forms.ListView listViewAnswerPopRated;
        private System.Windows.Forms.Button buttonPopRated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTopRated;
        private System.Windows.Forms.TextBox textBoxTopPop;
        private System.Windows.Forms.Label label1;
    }
}

