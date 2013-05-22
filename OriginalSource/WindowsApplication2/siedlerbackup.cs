using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public class HighScoreEntry
    {
        public string name;
        public int score;

        public HighScoreEntry(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    public class HighScoreTable
    {
        private ArrayList table;

        private bool isLoaded;

        public HighScoreTable()
        {
            table = new ArrayList();
            isLoaded = false;
        }

        public void Load(string path)
        {
            if (File.Exists(path))
            {
                table = new ArrayList();

                using (StreamReader textStream = new StreamReader(path, Encoding.UTF8))
                {
                    string scoreLine;

                    while ((scoreLine = textStream.ReadLine()) != null)
                    {
                        string[] scoreParts = scoreLine.Split(',');

                        if (scoreParts.Length != 2)
                        {
                            throw new ApplicationException("Score file corrupt!");
                        }
                        else
                        {
                            table.Add(new HighScoreEntry(scoreParts[0], Int32.Parse(scoreParts[1])));
                        }
                    }
                    textStream.Close();
                }
            }
            else
            {
                for (int index = 0; index < 10; index++)
                {
                    table.Add(new HighScoreEntry("Simon", 0));
                }
                Save(path);
            }
            isLoaded = true;
        }

        public void Save(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter textStream = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach (object tableEntry in table)
                {
                    HighScoreEntry highScoreEntry = tableEntry as HighScoreEntry;

                    textStream.WriteLine("{0},{1}", highScoreEntry.name, highScoreEntry.score);
                }
                textStream.Close();
            }
        }

        public int GetIndexOfScore(int score)
        {
            for (int index = 0; index < table.Count; index++)
            {
                HighScoreEntry highScoreEntry = table[index] as HighScoreEntry;

                if (score > highScoreEntry.score && index < 10)
                {
                    return index;
                }
            }
            return -1;
        }

        public void Update(string name, int score)
        {
            if (!isLoaded) Load(Application.StartupPath + @"\score.txt");

            int index = GetIndexOfScore(score);

            if (index > -1)
            {
                if (table.Count > 9) table.RemoveAt(9);
                table.Insert(index, new HighScoreEntry(name, score));
                Save(Application.StartupPath + @"\score.txt");
            }
        }

        public void Populate(ListView listView)
        {
            listView.Items.Clear();

            foreach (object entry in table)
            {
                HighScoreEntry highScoreEntry = entry as HighScoreEntry;
                listView.Items.Add(new ListViewItem(new string[] { highScoreEntry.name, highScoreEntry.score.ToString() }));
            }
        }
    }

    public class HighScore : Form
    {
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private HighScoreTable highScoreTable = null;

        private System.ComponentModel.Container components = null;

        public HighScore(HighScoreTable highScoreTableReference)
        {
            InitializeComponent();
            highScoreTable = highScoreTableReference;
        }

        private void InitializeComponent()
        {
            this.listView1 = new ListView();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();

            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] {
														  columnHeader1,
														  columnHeader2});
            listView1.GridLines = true;
            listView1.Location = new Point(16, 16);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.Size = new Size(210, 162);
            listView1.TabIndex = 0;
            listView1.View = View.Details;

            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;

            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";

            // 
            // HighScore
            // 
            this.ClientSize = new Size(242, 192);
            this.Controls.Add(listView1);
            this.Text = "High Scores";

            // Now Load Scores
            this.Load += new System.EventHandler(HighScoreForm_Load);

            this.ResumeLayout(false);
        }

        private void HighScoreForm_Load(object sender, System.EventArgs e)
        {
            highScoreTable.Load(Application.StartupPath + @"\score.txt");
            highScoreTable.Populate(listView1);
        }
    }

    public partial class Form1 : Form
    {
        private HighScoreTable highScoreTable = new HighScoreTable();
        public int wuerf1 = 1;
        public int wuerf2 = 2;
        public int wuerf3 = 3;
        public int wuerf4 = 4;
        public int wuerf5 = 5;
        public int wuerf6 = 6;
        public int wuerfe = 3;
        public int gold = 0;
        public int punkte = 0;
        public int punkteges = 0;
        public int rundenzahl = 1;
        public int ritterjoker = 0;

        public int wuerf10 = 0;
        public int wuerf20 = 0;
        public int wuerf30 = 0;
        public int wuerf40 = 0;
        public int wuerf50 = 0;
        public int wuerf60 = 0;
        
        public int stadt = 0;
        public int siedlung = 0;
        public int ritter = 0;
        public int strasse = 0;
        public int stastr = 0;
        public bool stastr1 = false;
        public bool stastr2 = false;
        public bool gebaut = false;

        public bool ritter01an = false;
        public bool ritter01ben = false;
        public bool ritter02an = false;
        public bool ritter02ben = false;
        public bool ritter03an = false;
        public bool ritter03ben = false;
        public bool ritter04an = false;
        public bool ritter04ben = false;
        public bool ritter05an = false;
        public bool ritter05ben = false;
        public bool ritter06an = false;
        public bool ritter06ben = false;
        public bool ritter01fertig = false;
        public bool ritter02fertig = false;
        public bool ritter03fertig = false;
        public bool ritter04fertig = false;
        public bool ritter05fertig = false;
        public bool ritter06fertig = false;

        public int lehm = 0;
        public int holz = 0;
        public int schaaf = 0;
        public int getreide = 0;
        public int erz = 0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = WindowsApplication1.Properties.Resources.gold6;
            pictureBox2.Image = WindowsApplication1.Properties.Resources.gold6;
            pictureBox3.Image = WindowsApplication1.Properties.Resources.gold6;
            pictureBox4.Image = WindowsApplication1.Properties.Resources.gold6;
            pictureBox5.Image = WindowsApplication1.Properties.Resources.gold6;
            pictureBox6.Image = WindowsApplication1.Properties.Resources.gold6;
            wurfbeenden.Enabled = false;
            ritter01.Enabled = false;
            stadt01.Enabled = false;
            siedlung01.Enabled = false;
            ritterauswahl1.Visible = false;
            ritterauswahl2.Visible = false;
            ritterauswahl3.Visible = false;
            ritterauswahl4.Visible = false;
            ritterauswahl5.Visible = false;

        }
  
  private void CheckHighScore()
  {
	  highScoreTable.Load( Application.StartupPath+@"\score.txt" );

      int score = punkteges;

	  int scoreIndex = highScoreTable.GetIndexOfScore( score );

	  if( scoreIndex > -1 )
	  {
          string name = "";
          using (Form2 aForm = new Form2())
          {
              aForm.StartPosition = FormStartPosition.CenterScreen;

              if (aForm.ShowDialog() == DialogResult.OK)
              {
                  name = "Simon";

                  highScoreTable.Update(name, score);
              }
          }
	  }
  }
        
        private void ritterjokan()
        {
            ritterauswahl1.Visible = true;
            ritterauswahl2.Visible = true;
            ritterauswahl3.Visible = true;
            ritterauswahl4.Visible = true;
            ritterauswahl5.Visible = true;
            ritterauswahl1.Enabled = true;
            ritterauswahl2.Enabled = true;
            ritterauswahl3.Enabled = true;
            ritterauswahl4.Enabled = true;
            ritterauswahl5.Enabled = true;
            button2.Enabled = false;
        }

        private void ritterjokaus()
        {
            ritterauswahl1.Visible = false;
            ritterauswahl2.Visible = false;
            ritterauswahl3.Visible = false;
            ritterauswahl4.Visible = false;
            ritterauswahl5.Visible = false;
            ritterauswahl1.Enabled = false;
            ritterauswahl2.Enabled = false;
            ritterauswahl3.Enabled = false;
            ritterauswahl4.Enabled = false;
            ritterauswahl5.Enabled = false;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            wurfbeenden.Enabled = true;
            if (wuerf1 > 0)
                wuerf1 = rnd.Next(1, 7);
            
            if (wuerf2 > 0)
                wuerf2 = rnd.Next(1, 7);
            
            if (wuerf3 > 0)
                wuerf3 = rnd.Next(1, 7);
            
            if (wuerf4 > 0)
                wuerf4 = rnd.Next(1, 7);
            
            if (wuerf5 > 0)
                wuerf5 = rnd.Next(1, 7);
            
            if (wuerf6 > 0)
                wuerf6 = rnd.Next(1, 7);
            zeichnen();
            wuerfe = wuerfe - 1;
            label2.Text = wuerfe.ToString();
            if (wuerfe == 0)
            {
                button1.Enabled = false;
                wurfbeenden.Enabled = false;
                if (wuerf10 == 0)
                {
                    wuerf10 = wuerf1;
                    wuerf1 = 0;
                    zeichnen();
                }
                if (wuerf20 == 0)
                {
                    wuerf20 = wuerf2;
                    wuerf2 = 0;
                    zeichnen();
                }
                if (wuerf30 == 0)
                {
                    wuerf30 = wuerf3;
                    wuerf3 = 0;
                    zeichnen();
                }
                if (wuerf40 == 0)
                {
                    wuerf40 = wuerf4;
                    wuerf4 = 0;
                    zeichnen();    
                }
                if (wuerf50 == 0)
                {
                    wuerf50 = wuerf5;
                    wuerf5 = 0;
                    zeichnen();    
                }
                if (wuerf60 == 0)
                {
                    wuerf60 = wuerf6;
                    wuerf6 = 0;
                    zeichnen();
                }
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
            //Gold umwandeln
                bauen();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (wuerfe < 3)
            {
                if (wuerf1 > 0)
                    wuerf10 = wuerf1;
                wuerf1 = 0;
                zeichnen();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (wuerf10 > 0)
            {
                if ((ritter01ben == true) & (ritter01an == true) & (ritter01fertig == false))
                {
                    wuerf10 = 5;
                    ritter01fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true) & (ritter02fertig == false))
                {
                    wuerf10 = 4;
                    ritter02fertig = true;                    
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true) & (ritter03fertig == false))
                {
                    wuerf10 = 3;
                    ritter03fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true) & (ritter04fertig == false))
                {
                    wuerf10 = 1;
                    ritter04fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true) & (ritter05fertig == false))
                {
                    wuerf10 = 2;
                    ritter05fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter06ben == true) & (ritter06an == true) & (ritterjoker > 0))
                {
                    wuerf10 = ritterjoker;
                    ritter06fertig = true;
                    ritterjoker = 0;
                    zeichnen();
                    bauen();
                }
                if ((wuerf10 > 0) & (wuerfe > 0))
                {
                    wuerf1 = wuerf10;
                    wuerf10 = 0;
                    zeichnen();
                }
            }
            else
                ritteraus();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (wuerfe < 3)
            {
                if (wuerf2 > 0)
                    wuerf20 = wuerf2;
                wuerf2 = 0;
                zeichnen();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (wuerf20 > 0)
            {
                if ((ritter01ben == true) & (ritter01an == true) & (ritter01fertig == false))
                {
                    wuerf20 = 5;
                    ritter01fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true) & (ritter02fertig == false))
                {
                    wuerf20 = 4;
                    ritter02fertig = true; 
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true) & (ritter03fertig == false))
                {
                    wuerf20 = 3;
                    ritter03fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true) & (ritter04fertig == false))
                {
                    wuerf20 = 1;
                    ritter04fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true) & (ritter05fertig == false))
                {
                    wuerf20 = 2;
                    ritter05fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter06ben == true) & (ritter06an == true) & (ritterjoker > 0))
                {
                    wuerf20 = ritterjoker;
                    ritter06fertig = true;
                    ritterjoker = 0;
                    zeichnen();
                    bauen();
                }
                if ((wuerf20 > 0) & (wuerfe > 0))
                {
                    wuerf2 = wuerf20;
                    wuerf20 = 0;
                    zeichnen();
                }
            }
            else
                ritteraus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (wuerfe < 3)
            {
                if (wuerf3 > 0)
                    wuerf30 = wuerf3;
                wuerf3 = 0;
                zeichnen();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (wuerf30 > 0)
            {
                if ((ritter01ben == true) & (ritter01an == true) & (ritter01fertig == false))
                {
                    wuerf30 = 5;
                    ritter01fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true) & (ritter02fertig == false))
                {
                    wuerf30 = 4;
                    ritter02fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true) & (ritter03fertig == false))
                {
                    wuerf30 = 3;
                    ritter03fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true) & (ritter04fertig == false))
                {
                    wuerf30 = 1;
                    ritter04fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true) & (ritter05fertig == false))
                {
                    wuerf30 = 2;
                    ritter05fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter06ben == true) & (ritter06an == true) & (ritterjoker > 0))
                {
                    wuerf30 = ritterjoker;
                    ritter06fertig = true;
                    ritterjoker = 0;
                    zeichnen();
                    bauen();
                }
                if ((wuerf30 > 0) & (wuerfe > 0))
                {
                    wuerf3 = wuerf30;
                    wuerf30 = 0;
                    zeichnen();
                }
            }
            else
                ritteraus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (wuerfe < 3)
            {
                if (wuerf4 > 0)
                    wuerf40 = wuerf4;
                wuerf4 = 0;
                zeichnen();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (wuerf40 > 0)
            {
                if ((ritter01ben == true) & (ritter01an == true) & (ritter01fertig == false))
                {
                    wuerf40 = 5;
                    ritter01fertig = true; 
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true) & (ritter02fertig == false))
                {
                    wuerf40 = 4;
                    ritter02fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true) & (ritter03fertig == false))
                {
                    wuerf40 = 3;
                    ritter03fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true) & (ritter04fertig == false))
                {
                    wuerf40 = 1;
                    ritter04fertig = true; 
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true) & (ritter05fertig == false))
                {
                    wuerf40 = 2;
                    ritter05fertig = true; 
                    zeichnen();
                    bauen();
                }
                if ((ritter06ben == true) & (ritter06an == true) & (ritterjoker > 0))
                {
                    wuerf40 = ritterjoker;
                    ritter06fertig = true;
                    ritterjoker = 0;
                    zeichnen();
                    bauen();
                }
                if ((wuerf40 > 0) & (wuerfe > 0))
                {
                    wuerf4 = wuerf40;
                    wuerf40 = 0;
                    zeichnen();
                }
            }
            else
                ritteraus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (wuerfe < 3)
            {
                if (wuerf5 > 0)
                    wuerf50 = wuerf5;
                wuerf5 = 0;
                zeichnen();
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (wuerf50 > 0)
            {
                if ((ritter01ben == true) & (ritter01an == true) & (ritter01fertig == false))
                {
                    wuerf50 = 5;
                    ritter01fertig = true; 
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true) & (ritter02fertig == false))
                {
                    wuerf50 = 4;
                    ritter02fertig = true; 
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true) & (ritter03fertig == false))
                {
                    wuerf50 = 3;
                    ritter03fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true) & (ritter04fertig == false))
                {
                    wuerf50 = 1;
                    ritter04fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true) & (ritter05fertig == false))
                {
                    wuerf50 = 2;
                    ritter05fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter06ben == true) & (ritter06an == true) & (ritterjoker > 0))
                {
                    wuerf50 = ritterjoker;
                    ritter06fertig = true;
                    ritterjoker = 0;
                    zeichnen();
                    bauen();
                }
                if ((wuerf50 > 0) & (wuerfe > 0))
                {
                    wuerf5 = wuerf50;
                    wuerf50 = 0;
                    zeichnen();
                }

            }
            else
                ritteraus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (wuerfe < 3)
            {
                if (wuerf6 > 0)
                    wuerf60 = wuerf6;
                wuerf6 = 0;
                zeichnen();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (wuerf60 > 0)
            {
                if ((ritter01ben == true) & (ritter01an == true) & (ritter01fertig == false))
                {
                    wuerf60 = 5;
                    ritter01fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true) & (ritter02fertig == false))
                {
                    wuerf60 = 4;
                    ritter02fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true) & (ritter03fertig == false))
                {
                    wuerf60 = 3;
                    ritter03fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true) & (ritter04fertig == false))
                {
                    wuerf60 = 1;
                    ritter04fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true) & (ritter05fertig == false))
                {
                    wuerf60 = 2;
                    ritter05fertig = true;
                    zeichnen();
                    bauen();
                }
                if ((ritter06ben == true) & (ritter06an == true) & (ritterjoker > 0))
                {
                    wuerf60 = ritterjoker;
                    ritter06fertig = true;
                    ritterjoker = 0; 
                    zeichnen();
                    bauen();
                }
                if ((wuerf60 > 0) & (wuerfe > 0))
                {
                    wuerf6 = wuerf60;
                    wuerf60 = 0;
                    zeichnen();
                }
            }
            else
                ritteraus();
        }

        private void ritteraus()
        {
            if ((ritter01an == true) & (ritter01ben = true) & (ritter01fertig = false))
                ritter01an = false;
            if ((ritter02an == true) & (ritter02ben = true) & (ritter02fertig = false))
                ritter02an = false;
            if ((ritter03an == true) & (ritter03ben = true) & (ritter03fertig = false))
                ritter03an = false;
            if ((ritter04an == true) & (ritter04ben = true) & (ritter04fertig = false))
                ritter04an = false;
            if ((ritter05an == true) & (ritter05ben = true) & (ritter05fertig = false))
                ritter06an = false;
            if ((ritter06an == true) & (ritter06ben = true) & (ritter06fertig = false))
                ritter06an = false;
            ritterzeichnen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
                if (wuerf10 == 0)
                {
                    wuerf10 = wuerf1;
                    wuerf1 = 0;
                 }
                if (wuerf20 == 0)
                {
                    wuerf20 = wuerf2;
                    wuerf2 = 0;
                 }
                if (wuerf30 == 0)
                {
                    wuerf30 = wuerf3;
                    wuerf3 = 0;
                }
                if (wuerf40 == 0)
                {
                    wuerf40 = wuerf4;
                    wuerf4 = 0;
                 }
                if (wuerf50 == 0)
                {
                    wuerf50 = wuerf5;
                    wuerf5 = 0;
                 }
                if (wuerf60 == 0)
                {
                    wuerf60 = wuerf6;
                    wuerf6 = 0;
                }
                zeichnen();
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                wurfbeenden.Enabled = false;
                wuerfe = 0;
                label2.Text = wuerfe.ToString();
                bauen();
            }

        //Gold auswählen

        private void picgold1_Click(object sender, EventArgs e)
        {
            if (wuerf10 == 6)
            {
                wuerf10 = 1;
                if (wuerf20 == 6)
                    wuerf20 = 0;
                else
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
            }
            else
                if (wuerf20 == 6)
                {
                    wuerf20 = 1;
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                }
                else
                    if (wuerf30 == 6)
                    {
                        wuerf30 = 1;
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                    }
                    else
                        if (wuerf40 == 6)
                        {
                            wuerf40 = 1;
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                        }
                        else
                            if (wuerf50 == 6)
                            {
                                wuerf50 = 1;
                                wuerf60 = 0;
                            }
            zeichnen();
            bauen();
        }

        private void picgold2_Click(object sender, EventArgs e)
        {
            if (wuerf10 == 6)
            {
                wuerf10 = 2;
                if (wuerf20 == 6)
                    wuerf20 = 0;
                else
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
            }
            else
                if (wuerf20 == 6)
                {
                    wuerf20 = 2;
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                }
                else
                    if (wuerf30 == 6)
                    {
                        wuerf30 = 2;
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                    }
                    else
                        if (wuerf40 == 6)
                        {
                            wuerf40 = 2;
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                        }
                        else
                            if (wuerf50 == 6)
                            {
                                wuerf50 = 2;
                                wuerf60 = 0;
                            }
            zeichnen();
            bauen();
        }

        private void picgold3_Click(object sender, EventArgs e)
        {
            if (wuerf10 == 6)
            {
                wuerf10 = 3;
                if (wuerf20 == 6)
                    wuerf20 = 0;
                else
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
            }
            else
                if (wuerf20 == 6)
                {
                    wuerf20 = 3;
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                }
                else
                    if (wuerf30 == 6)
                    {
                        wuerf30 = 3;
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                    }
                    else
                        if (wuerf40 == 6)
                        {
                            wuerf40 = 3;
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                        }
                        else
                            if (wuerf50 == 6)
                            {
                                wuerf50 = 3;
                                wuerf60 = 0;
                            }
            zeichnen();
            bauen();
        }

        private void picgold4_Click(object sender, EventArgs e)
        {
            if (wuerf10 == 6)
            {
                wuerf10 = 4;
                if (wuerf20 == 6)
                    wuerf20 = 0;
                else
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
            }
            else
                if (wuerf20 == 6)
                {
                    wuerf20 = 4;
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                }
                else
                    if (wuerf30 == 6)
                    {
                        wuerf30 = 4;
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                    }
                    else
                        if (wuerf40 == 6)
                        {
                            wuerf40 = 4;
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                        }
                        else
                            if (wuerf50 == 6)
                            {
                                wuerf50 = 4;
                                wuerf60 = 0;
                            }
            zeichnen();
            bauen();
        }

        private void picgold5_Click(object sender, EventArgs e)
        {
           if (wuerf10 == 6)
           {
                    wuerf10 = 5;
               if (wuerf20 == 6)
                   wuerf20 = 0;
               else
                    if (wuerf30 == 6)
                        wuerf30 = 0;
                    else
                        if (wuerf40 == 6)
                            wuerf40 = 0;
                        else
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
           }
           else
               if (wuerf20 == 6)
               {
                   wuerf20 = 5;
                   if (wuerf30 == 6)
                       wuerf30 = 0;
                   else
                       if (wuerf40 == 6)
                           wuerf40 = 0;
                       else
                           if (wuerf50 == 6)
                               wuerf50 = 0;
                           else
                               if (wuerf60 == 6)
                                   wuerf60 = 0;
               }
               else
                   if (wuerf30 == 6)
                   {
                       wuerf30 = 5;
                       if (wuerf40 == 6)
                           wuerf40 = 0;
                       else
                           if (wuerf50 == 6)
                               wuerf50 = 0;
                           else
                               if (wuerf60 == 6)
                                   wuerf60 = 0;
                   }
                   else
                        if (wuerf40 == 6)
                        {
                            wuerf40 = 5;
                            if (wuerf50 == 6)
                                wuerf50 = 0;
                            else
                                if (wuerf60 == 6)
                                    wuerf60 = 0;
                        }
                        else
                            if (wuerf50 == 6)
                            {
                                wuerf50 = 5;
                                wuerf60 = 0;
                            }
            zeichnen();
            bauen();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        // Zeichen- und Baufunktion
        
        public void zeichnen()
        {
            //Wuerfel unten
            if (wuerf1 == 0)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf1 == 1)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf1 == 2)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf1 == 3)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf1 == 4)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf1 == 5)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf1 == 6)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf2 == 0)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf2 == 1)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf2 == 2)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf2 == 3)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf2 == 4)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf2 == 5)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf2 == 6)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf3 == 0)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf3 == 1)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf3 == 2)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf3 == 3)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf3 == 4)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf3 == 5)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf3 == 6)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf4 == 0)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.blank;            
            if (wuerf4 == 1)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf4 == 2)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf4 == 3)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf4 == 4)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf4 == 5)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf4 == 6)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf5 == 0)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf5 == 1)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf5 == 2)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf5 == 3)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf5 == 4)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf5 == 5)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf5 == 6)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf6 == 0)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf6 == 1)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf6 == 2)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf6 == 3)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf6 == 4)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf6 == 5)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf6 == 6)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.gold6;

            //Wuerfel oben
            if (wuerf10 == 0)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf10 == 1)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf10 == 2)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf10 == 3)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf10 == 4)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf10 == 5)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf10 == 6)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf20 == 0)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf20 == 1)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf20 == 2)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf20 == 3)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf20 == 4)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf20 == 5)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf20 == 6)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf30 == 0)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf30 == 1)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf30 == 2)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf30 == 3)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf30 == 4)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf30 == 5)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf30 == 6)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf40 == 0)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf40 == 1)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf40 == 2)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf40 == 3)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf40 == 4)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf40 == 5)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf40 == 6)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf50 == 0)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf50 == 1)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf50 == 2)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf50 == 3)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf50 == 4)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf50 == 5)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf50 == 6)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.gold6;

            if (wuerf60 == 0)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.blank;
            if (wuerf60 == 1)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.holz1;
            if (wuerf60 == 2)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.lehm2;
            if (wuerf60 == 3)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (wuerf60 == 4)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.getreide4;
            if (wuerf60 == 5)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.erz5;
            if (wuerf60 == 6)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.gold6;
        }

        private void ritterzeichnen()
        {
            if (ritter01ben == true)
                if (ritter01an == true)
                    ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_ben;
                else
                    ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_an;
            else
                if (ritter01an == true)
                    ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_aus;
                else
                    ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_frei;

            if (ritter02ben == true)
                if (ritter02an == true)
                    ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_ben;
                else
                    ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_an;
            else
                if (ritter02an == true)
                    ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_aus;
                else
                    ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_frei;

            if (ritter03ben == true)
                if (ritter03an == true)
                    ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_ben;
                else
                    ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_an;
            else
                if (ritter03an == true)
                    ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_aus;
                else
                    ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_frei;

            if (ritter04ben == true)
                if (ritter04an == true)
                    ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_ben;
                else
                    ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_an;
            else
                if (ritter04an == true)
                    ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_aus;
                else
                    ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_frei;

            if (ritter05ben == true)
                if (ritter05an == true)
                    ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_ben;
                else
                    ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_an;
            else
                if (ritter05an == true)
                    ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_aus;
                else
                    ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_frei;

            if (ritter06ben == true)
                if (ritter06an == true)
                    ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_ben;
                else
                    ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_an;
            else
                if (ritter06an == true)
                    ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_aus;
                else
                    ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_frei;

        }

        public void ausschalten()
        {
            stadt01.Enabled = false;
            stadt02.Enabled = false;
            stadt03.Enabled = false;
            stadt04.Enabled = false;

            siedlung01.Enabled = false;
            siedlung02.Enabled = false;
            siedlung03.Enabled = false;
            siedlung04.Enabled = false;
            siedlung05.Enabled = false;
            siedlung06.Enabled = false;

            ritter01.Enabled = false;
            ritter02.Enabled = false;
            ritter03.Enabled = false;
            ritter04.Enabled = false;
            ritter05.Enabled = false;
            ritter06.Enabled = false;

            strasse01.Enabled = false;
            strasse02.Enabled = false;
            strasse03.Enabled = false;
            strasse04.Enabled = false;
            strasse05.Enabled = false;
            strasse06.Enabled = false;
            strasse07.Enabled = false;
            strasse08.Enabled = false;
            strasse09.Enabled = false;
            strasse10.Enabled = false;

            stastr01.Enabled = false;
            stastr02.Enabled = false;
            stastr03.Enabled = false;
            stastr04.Enabled = false;
            stastr05.Enabled = false;
            stastr06.Enabled = false;

            if (stadt == 0)
            {
                stadt01.Image = WindowsApplication1.Properties.Resources.stadt_01_frei;
                stadt02.Image = WindowsApplication1.Properties.Resources.stadt_02_frei;
                stadt03.Image = WindowsApplication1.Properties.Resources.stadt_03_frei;
                stadt04.Image = WindowsApplication1.Properties.Resources.stadt_04_frei;
            }
            if (stadt == 1)
            {
                stadt02.Image = WindowsApplication1.Properties.Resources.stadt_02_frei;
                stadt03.Image = WindowsApplication1.Properties.Resources.stadt_03_frei;
                stadt04.Image = WindowsApplication1.Properties.Resources.stadt_04_frei;
            }
            if (stadt == 2)
            {
                stadt03.Image = WindowsApplication1.Properties.Resources.stadt_03_frei;
                stadt04.Image = WindowsApplication1.Properties.Resources.stadt_04_frei;
            }
            if (stadt == 3)
            {
                stadt04.Image = WindowsApplication1.Properties.Resources.stadt_04_frei;
            }
            if (siedlung == 0)
            {
                siedlung01.Image = WindowsApplication1.Properties.Resources.haus_01_frei;
                siedlung02.Image = WindowsApplication1.Properties.Resources.haus_02_frei;
                siedlung03.Image = WindowsApplication1.Properties.Resources.haus_03_frei;
                siedlung04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                siedlung05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (siedlung == 1)
            {
                siedlung02.Image = WindowsApplication1.Properties.Resources.haus_02_frei;
                siedlung03.Image = WindowsApplication1.Properties.Resources.haus_03_frei;
                siedlung04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                siedlung05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (siedlung == 2)
            {
                siedlung03.Image = WindowsApplication1.Properties.Resources.haus_03_frei;
                siedlung04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                siedlung05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (siedlung == 3)
            {
                siedlung04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                siedlung05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (siedlung == 4)
            {
                siedlung05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (siedlung == 5)
            {
                siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (ritter == 0)
            {
                ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_frei;
                ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_frei;
                ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_frei;
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_frei;
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_frei;
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_frei;
            }
            if (ritter == 1)
            {
                ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_frei;
                ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_frei;
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_frei;
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_frei;
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_frei;
            }
            if (ritter == 2)
            {
                ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_frei;
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_frei;
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_frei;
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_frei;
            }
            if (ritter == 3)
            {
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_frei;
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_frei;
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_frei;
            }
            if (ritter == 4)
            {
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_frei;
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_frei;
            }
            if (ritter == 5)
            {
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_frei;
            }

            if (strasse == 0)
            {
                strasse01.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse02.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse03.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse04.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
                strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 1)
            {
                strasse02.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse03.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse04.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
                strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 2)
            {
                strasse03.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse04.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
                strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 3)
            {
                strasse04.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
                strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 4)
            {
                strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
                strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 5)
            {
                strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 6)
            {
                strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 7)
            {
                strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 8)
            {
                strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (strasse == 9)
            {
                strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }

            if (stastr == 0)
            {
                stastr03.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
                stastr04.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                stastr05.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                stastr06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (stastr == 1)
            {
                stastr04.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
                stastr05.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                stastr06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (stastr == 2)
            {
                stastr05.Image = WindowsApplication1.Properties.Resources.strasse_120_frei;
                stastr06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (stastr == 3)
            {
                stastr06.Image = WindowsApplication1.Properties.Resources.strasse_30_frei;
            }
            if (stastr1 == false)
            {
                stastr01.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
            }
            if (stastr2 == false)
            {
                stastr02.Image = WindowsApplication1.Properties.Resources.strasse_90_frei;
            }
        }

        public void bauen()
        {
            //Gold umwandeln
            gold = 0;
            if (wuerf10 == 6)
                gold = gold + 1;
            if (wuerf20 == 6)
                gold = gold + 1;
            if (wuerf30 == 6)
                gold = gold + 1;
            if (wuerf40 == 6)
                gold = gold + 1;
            if (wuerf50 == 6)
                gold = gold + 1;
            if (wuerf60 == 6)
                gold = gold + 1;
            if (gold > 1)
            {
                picgold1.Enabled = true;
                picgold2.Enabled = true;
                picgold3.Enabled = true;
                picgold4.Enabled = true;
                picgold5.Enabled = true;
                picgold1.Image = WindowsApplication1.Properties.Resources.holz1;
                picgold2.Image = WindowsApplication1.Properties.Resources.lehm2;
                picgold3.Image = WindowsApplication1.Properties.Resources.schaaf3;
                picgold4.Image = WindowsApplication1.Properties.Resources.getreide4;
                picgold5.Image = WindowsApplication1.Properties.Resources.erz5;
            }
            else
            {
                picgold1.Image = WindowsApplication1.Properties.Resources.grey;
                picgold2.Image = WindowsApplication1.Properties.Resources.grey;
                picgold3.Image = WindowsApplication1.Properties.Resources.grey;
                picgold4.Image = WindowsApplication1.Properties.Resources.grey;
                picgold5.Image = WindowsApplication1.Properties.Resources.grey;
                picgold1.Enabled = false;
                picgold2.Enabled = false;
                picgold3.Enabled = false;
                picgold4.Enabled = false;
                picgold5.Enabled = false;
                zeichnen();
                holz = 0;
                lehm = 0;
                schaaf = 0;
                getreide = 0;
                erz = 0;
                if (wuerf10 == 1)
                    lehm = lehm + 1;
                if (wuerf20 == 1)
                    lehm = lehm + 1;
                if (wuerf30 == 1)
                    lehm = lehm + 1;
                if (wuerf40 == 1)
                    lehm = lehm + 1;
                if (wuerf50 == 1)
                    lehm = lehm + 1;
                if (wuerf60 == 1)
                    lehm = lehm + 1;

                if (wuerf10 == 2)
                    holz = holz + 1;
                if (wuerf20 == 2)
                    holz = holz + 1;
                if (wuerf30 == 2)
                    holz = holz + 1;
                if (wuerf40 == 2)
                    holz = holz + 1;
                if (wuerf50 == 2)
                    holz = holz + 1;
                if (wuerf60 == 2)
                    holz = holz + 1;

                if (wuerf10 == 3)
                    schaaf = schaaf + 1;
                if (wuerf20 == 3)
                    schaaf = schaaf + 1;
                if (wuerf30 == 3)
                    schaaf = schaaf + 1;
                if (wuerf40 == 3)
                    schaaf = schaaf + 1;
                if (wuerf50 == 3)
                    schaaf = schaaf + 1;
                if (wuerf60 == 3)
                    schaaf = schaaf + 1;

                if (wuerf10 == 4)
                    getreide = getreide + 1;
                if (wuerf20 == 4)
                    getreide = getreide + 1;
                if (wuerf30 == 4)
                    getreide = getreide + 1;
                if (wuerf40 == 4)
                    getreide = getreide + 1;
                if (wuerf50 == 4)
                    getreide = getreide + 1;
                if (wuerf60 == 4)
                    getreide = getreide + 1;

                if (wuerf10 == 5)
                    erz = erz + 1;
                if (wuerf20 == 5)
                    erz = erz + 1;
                if (wuerf30 == 5)
                    erz = erz + 1;
                if (wuerf40 == 5)
                    erz = erz + 1;
                if (wuerf50 == 5)
                    erz = erz + 1;
                if (wuerf60 == 5)
                    erz = erz + 1;

                if ((ritter01an == true) & (ritter01ben == false))
                    ritter01an = false;
                if ((ritter02an == true) & (ritter02ben == false))
                    ritter02an = false;
                if ((ritter03an == true) & (ritter03ben == false))
                    ritter03an = false;
                if ((ritter04an == true) & (ritter04ben == false))
                    ritter04an = false;
                if ((ritter05an == true) & (ritter05ben == false))
                    ritter05an = false;
                if ((ritter06an == true) & (ritter06ben == false))
                    ritter06an = false;

                if ((ritter01an == false) & (ritter01ben == true))
                    ritter01.Enabled = true;
                if ((ritter02an == false) & (ritter02ben == true))
                    ritter02.Enabled = true;
                if ((ritter03an == false) & (ritter03ben == true))
                    ritter03.Enabled = true;
                if ((ritter04an == false) & (ritter04ben == true))
                    ritter04.Enabled = true;
                if ((ritter05an == false) & (ritter05ben == true))
                    ritter05.Enabled = true;
                if ((ritter06an == false) & (ritter06ben == true))
                    ritter06.Enabled = true;
                //bauen aktivieren
                ritterzeichnen();
                if ((erz > 0) & (schaaf > 0) & (getreide > 0))
                {
                    if (ritter == 0)
                    {
                        ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_aus;
                        ritter01an = true;
                        ritter01.Enabled = true;
                        if ((ritter01an == true) & (ritter01ben == true))
                        {
                            ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_ben;
                            ritter01.Enabled = false;
                        }
                    }
                    
                    if (ritter == 1)
                    {
                        ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_aus;
                        ritter02an = true;
                        ritter02.Enabled = true;
                        if ((ritter02an == true) & (ritter02ben == true))
                        {
                            ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_ben;
                            ritter02.Enabled = false;
                        }
                    }

                    if (ritter == 2)
                    {
                        ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_aus;
                        ritter03an = true;
                        ritter03.Enabled = true;
                        if ((ritter03an == true) & (ritter03ben == true))
                        {
                            ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_ben;
                            ritter03.Enabled = false;
                        }
                    }

                    if (ritter == 3)
                    {
                        ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_aus;
                        ritter04an = true;
                        ritter04.Enabled = true;
                        if ((ritter04an == true) & (ritter04ben == true))
                        {
                            ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_ben;
                            ritter04.Enabled = false;
                        }
                    }

                    if (ritter == 4)
                    {
                        ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_aus;
                        ritter05an = true;
                        ritter05.Enabled = true;
                        if ((ritter05an == true) & (ritter05ben == true))
                        {
                            ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_ben;
                            ritter05.Enabled = false;
                        }
                    }

                    if (ritter == 5)
                    {
                        ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_aus;
                        ritter06an = true;
                        ritter06.Enabled = true;
                        if ((ritter06an == true) & (ritter06ben == true))
                        {
                            ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_ben;
                            ritter06.Enabled = false;
                        }
                    }
                 
                }
                
                if ((lehm > 0) & (holz> 0) & (schaaf > 0) & (getreide > 0))
                {
                    if (siedlung == 0)
                    {
                        siedlung01.Image = WindowsApplication1.Properties.Resources.haus_01_aus; ;
                        siedlung01.Enabled = true;
                    }
                    if ((siedlung == 1)&(strasse>1))
                    {
                        siedlung02.Image = WindowsApplication1.Properties.Resources.haus_02_aus; ;
                        siedlung02.Enabled = true;
                    }
                    if ((siedlung == 2)&(strasse>3))
                    {
                        siedlung03.Image = WindowsApplication1.Properties.Resources.haus_03_aus; ;
                        siedlung03.Enabled = true;
                    }
                    if ((siedlung == 3)&(strasse>5))
                    {
                        siedlung04.Image = WindowsApplication1.Properties.Resources.haus_04_aus; ;
                        siedlung04.Enabled = true;
                    }
                    if ((siedlung == 4)&(strasse>7))
                    {
                        siedlung05.Image = WindowsApplication1.Properties.Resources.haus_05_aus; ;
                        siedlung05.Enabled = true;
                    }
                    if ((siedlung == 5)&(strasse>9))
                    {
                        siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_aus; ;
                        siedlung06.Enabled = true;
                    }

                }
                if ((erz > 2) & (getreide > 1))
                {
                    if ((stadt == 0) & (stastr1 == true))
                    {
                        stadt01.Image = WindowsApplication1.Properties.Resources.stadt_01_aus;
                        stadt01.Enabled = true;
                    }
                    if ((stadt == 1) & (stastr2 == true))
                    {
                        stadt02.Image = WindowsApplication1.Properties.Resources.stadt_02_aus;
                        stadt02.Enabled = true;
                    }
                    if ((stadt == 2) & (stastr > 1))
                    {
                        stadt03.Image = WindowsApplication1.Properties.Resources.stadt_03_aus;
                        stadt03.Enabled = true;
                    }
                    if ((stadt == 3) & (stastr > 3))
                    {
                        stadt04.Image = WindowsApplication1.Properties.Resources.stadt_04_aus;
                        stadt04.Enabled = true;
                    }
                }
                if ((lehm > 0) & (holz > 0))
                {
                    if (strasse == 0)
                    {
                        strasse01.Image = WindowsApplication1.Properties.Resources.strasse_30_aus;
                        strasse01.Enabled = true;
                    }
                    if (strasse == 1)
                    {
                        strasse02.Image = WindowsApplication1.Properties.Resources.strasse_120_aus;
                        strasse02.Enabled = true;
                    }
                    if (strasse == 2)
                    {
                        strasse03.Image = WindowsApplication1.Properties.Resources.strasse_30_aus;
                        strasse03.Enabled = true;
                    }
                    if (strasse == 3)
                    {
                        strasse04.Image = WindowsApplication1.Properties.Resources.strasse_120_aus;
                        strasse04.Enabled = true;
                    }
                    if (strasse == 4)
                    {
                        strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_aus;
                        strasse05.Enabled = true;
                    }
                    if (strasse == 5)
                    {
                        strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_aus;
                        strasse06.Enabled = true;
                    }
                    if (strasse == 6)
                    {
                        strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_aus;
                        strasse07.Enabled = true;
                    }
                    if (strasse == 7)
                    {
                        strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_aus;
                        strasse08.Enabled = true;
                    }
                    if (strasse == 8)
                    {
                        strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_aus;
                        strasse09.Enabled = true;
                    }
                    if (strasse == 9)
                    {
                        strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_aus;
                        strasse10.Enabled = true;
                    }
                }
                    if ((lehm > 0) & (holz > 0))
                {
                    if ((stastr1 == false) & (strasse>0))
                    {
                        stastr01.Image = WindowsApplication1.Properties.Resources.strasse_90_aus;
                        stastr01.Enabled = true;
                    }
                    if ((stastr2 == false) & (strasse>2))
                    {
                        stastr02.Image = WindowsApplication1.Properties.Resources.strasse_90_aus;
                        stastr02.Enabled = true;
                    }
                    if (strasse>5)
                    {
                        stastr03.Image = WindowsApplication1.Properties.Resources.strasse_90_aus;
                        stastr03.Enabled = true;
                    }
                    if (stastr == 1)
                    {
                        stastr04.Image = WindowsApplication1.Properties.Resources.strasse_30_aus;
                        stastr04.Enabled = true;
                    }
                    if (stastr == 2)
                    {
                        stastr05.Image = WindowsApplication1.Properties.Resources.strasse_120_aus;
                        stastr05.Enabled = true;
                    }
                    if (stastr == 3)
                    {
                        stastr06.Image = WindowsApplication1.Properties.Resources.strasse_30_aus;
                        stastr06.Enabled = true;
                    }
                }
                punkteschreiben();
            }
        }

        // Rohstoffreduzierung beim Bau
        
        public void baustadt()
        {
            if (stadt == 1)
                punkte = punkte + 7;
            if (stadt == 2)
                punkte = punkte + 12;
            if (stadt == 3)
                punkte = punkte + 20;
            if (stadt == 4)
                punkte = punkte + 30;
            
            for (int i = 1; i <= 3; )
            {
                if (wuerf10 == 5)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 5)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 5)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 5)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 5)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 5)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 2; )
            {
                if (wuerf10 == 4)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 4)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 4)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 4)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 4)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 4)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            zeichnen();
            ausschalten();
            bauen();
        }

        public void bausiedlung()
        {
            if (siedlung == 1)
                punkte = punkte + 3;
            if (siedlung == 2)
                punkte = punkte + 4;
            if (siedlung == 3)
                punkte = punkte + 5;
            if (siedlung == 4)
                punkte = punkte + 7;
            if (siedlung == 5)
                punkte = punkte + 9;
            if (siedlung == 6)
                punkte = punkte + 11;

            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 1)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 1)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 1)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 1)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 1)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 1)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 2)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 2)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 2)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 2)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 2)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 2)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 3)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 3)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 3)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 3)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 3)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 3)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 4)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 4)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 4)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 4)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 4)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 4)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            zeichnen();
            ausschalten();
            bauen();
        }

        public void bauritter()
        {
            if (ritter == 1)
                punkte = punkte + 1;
            if (ritter == 2)
                punkte = punkte + 2;
            if (ritter == 3)
                punkte = punkte + 3;
            if (ritter == 4)
                punkte = punkte + 4;
            if (ritter == 5)
                punkte = punkte + 5;
            if (ritter == 6)
                punkte = punkte + 6;

            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 3)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 3)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 3)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 3)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 3)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 3)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 4)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 4)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 4)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 4)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 4)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 4)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 5)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 5)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 5)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 5)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 5)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 5)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
                zeichnen();
                ausschalten();
                bauen();
            }
        }

        public void baustrasse()
        {
            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 1)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 1)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 1)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 1)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 1)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 1)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (wuerf10 == 2)
                {
                    wuerf10 = 0;
                    i++;
                }
                else
                    if (wuerf20 == 2)
                    {
                        wuerf20 = 0;
                        i++;
                    }
                    else
                        if (wuerf30 == 2)
                        {
                            wuerf30 = 0;
                            i++;
                        }
                        else
                            if (wuerf40 == 2)
                            {
                                wuerf40 = 0;
                                i++;
                            }
                            else
                                if (wuerf50 == 2)
                                {
                                    wuerf50 = 0;
                                    i++;
                                }
                                else
                                    if (wuerf60 == 2)
                                    {
                                        wuerf60 = 0;
                                        i++;
                                    }
            }
                zeichnen();
                ausschalten();
                bauen();
            }

        // Elemente bauen
        
        private void stadt01_Click(object sender, EventArgs e)
        {
            stadt01.Image = WindowsApplication1.Properties.Resources.stadt_01_an;
            stadt = 1;
            baustadt();
            bauen();
        }

        private void stadt02_Click(object sender, EventArgs e)
        {
            stadt02.Image = WindowsApplication1.Properties.Resources.stadt_02_an;
            stadt = 2; 
            baustadt();
            bauen();
        }

        private void stadt03_Click(object sender, EventArgs e)
        {
            stadt03.Image = WindowsApplication1.Properties.Resources.stadt_03_an;
            stadt = 3;
            baustadt();
            bauen();
        }

        private void stadt04_Click(object sender, EventArgs e)
        {
            stadt04.Image = WindowsApplication1.Properties.Resources.stadt_04_an;
            stadt = 4;
            baustadt();
            bauen();
        }

        private void siedlung01_Click(object sender, EventArgs e)
        {
            siedlung01.Image = WindowsApplication1.Properties.Resources.haus_01_an;
            siedlung = 1;
            bausiedlung();
            bauen();
        }

        private void siedlung02_Click(object sender, EventArgs e)
        {
            siedlung02.Image = WindowsApplication1.Properties.Resources.haus_02_an;
            siedlung = 2;
            bausiedlung();
            bauen();
        }

        private void siedlung03_Click(object sender, EventArgs e)
        {
            siedlung03.Image = WindowsApplication1.Properties.Resources.haus_03_an;
            siedlung = 3;
            bausiedlung();
            bauen();
        }

        private void siedlung04_Click(object sender, EventArgs e)
        {
            siedlung04.Image = WindowsApplication1.Properties.Resources.haus_04_an;
            siedlung = 4;
            bausiedlung();
            bauen();
        }

        private void siedlung05_Click(object sender, EventArgs e)
        {
            siedlung05.Image = WindowsApplication1.Properties.Resources.haus_05_an;
            siedlung = 5;
            bausiedlung();
            bauen();
        }

        private void siedlung06_Click(object sender, EventArgs e)
        {
            siedlung06.Image = WindowsApplication1.Properties.Resources.haus_06_an;
            siedlung = 6;
            bausiedlung();
            bauen();
        }

        private void ritter01_Click(object sender, EventArgs e)
        {
            // Ritter bauen
            if ((ritter01an == true) & (ritter01ben == false))
            {
                ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_an;
                ritter = 1;
                ritter01an = false;
                ritter01ben = true;
                bauritter();
                bauen();
            }
            else
            // Ritter aktivieren andere deaktivieren
            {
                if ((ritter01an == false) & (ritter01ben == true))
                {
                    ritter01an = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    if ((ritter02an == true) & (ritter02ben == true) & (ritter02fertig == false))
                        ritter02an = false;
                    if ((ritter03an == true) & (ritter03ben == true) & (ritter03fertig == false))
                        ritter03an = false;
                    if ((ritter04an == true) & (ritter04ben == true) & (ritter04fertig == false))
                        ritter04an = false;
                    if ((ritter05an == true) & (ritter05ben == true) & (ritter05fertig == false))
                        ritter05an = false;
                    if ((ritter06an == true) & (ritter06ben == true) & (ritter06fertig == false))
                        ritter06an = false;
                    ritterzeichnen();
                }

            }
        }

        private void ritter02_Click(object sender, EventArgs e)
        {
            // Ritter bauen
            if ((ritter02an == true) & (ritter02ben == false))
            {
                ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_an;
                ritter = 2;
                ritter02an = false;
                ritter02ben = true;
                bauritter();
                bauen();
            }
            else
            // Ritter aktivieren andere deaktivieren
            {
                if ((ritter02an == false) & (ritter02ben == true))
                {
                    ritter02an = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    if ((ritter01an == true) & (ritter01ben == true) & (ritter01fertig == false))
                        ritter01an = false;
                    if ((ritter03an == true) & (ritter03ben == true) & (ritter03fertig == false))
                        ritter03an = false;
                    if ((ritter04an == true) & (ritter04ben == true) & (ritter04fertig == false))
                        ritter04an = false;
                    if ((ritter05an == true) & (ritter05ben == true) & (ritter05fertig == false))
                        ritter05an = false;
                    if ((ritter06an == true) & (ritter06ben == true) & (ritter06fertig == false))
                        ritter06an = false;
                    ritterzeichnen();
                }
            }
        }

        private void ritter03_Click(object sender, EventArgs e)
        {
            // Ritter bauen
            if ((ritter03an == true) & (ritter03ben == false))
            {
                ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_an;
                ritter = 3;
                ritter03an = false;
                ritter03ben = true;
                bauritter();
                bauen();
            }
            else
            // Ritter aktivieren andere deaktivieren
            {
                if ((ritter03an == false) & (ritter03ben == true))
                {
                    ritter03an = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    if ((ritter02an == true) & (ritter02ben == true) & (ritter02fertig == false))
                        ritter02an = false;
                    if ((ritter01an == true) & (ritter01ben == true) & (ritter01fertig == false))
                        ritter01an = false;
                    if ((ritter04an == true) & (ritter04ben == true) & (ritter04fertig == false))
                        ritter04an = false;
                    if ((ritter05an == true) & (ritter05ben == true) & (ritter05fertig == false))
                        ritter05an = false;
                    if ((ritter06an == true) & (ritter06ben == true) & (ritter06fertig == false))
                        ritter06an = false;
                    ritterzeichnen();
                }
            }
        }

        private void ritter04_Click(object sender, EventArgs e)
        {
            // Ritter bauen
            if ((ritter04an == true) & (ritter04ben == false))
            {
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_an;
                ritter = 4;
                ritter04an = false;
                ritter04ben = true;
                bauritter();
                bauen();
            }
            else
            // Ritter aktivieren andere deaktivieren
            {
                if ((ritter04an == false) & (ritter04ben == true))
                {
                    ritter04an = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    if ((ritter02an == true) & (ritter02ben == true) & (ritter02fertig == false))
                        ritter02an = false;
                    if ((ritter03an == true) & (ritter03ben == true) & (ritter03fertig == false))
                        ritter03an = false;
                    if ((ritter01an == true) & (ritter01ben == true) & (ritter01fertig == false))
                        ritter01an = false;
                    if ((ritter05an == true) & (ritter05ben == true) & (ritter05fertig == false))
                        ritter05an = false;
                    if ((ritter06an == true) & (ritter06ben == true) & (ritter06fertig == false))
                        ritter06an = false;
                    ritterzeichnen();
                }

            }
        }

        private void ritter05_Click(object sender, EventArgs e)
        {
            // Ritter bauen
            if ((ritter05an == true) & (ritter05ben == false))
            {
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_an;
                ritter = 5;
                ritter05an = false;
                ritter05ben = true;
                bauritter();
                bauen();
            }
            else
            // Ritter aktivieren andere deaktivieren
            {
                if ((ritter05an == false) & (ritter05ben == true))
                {
                    ritter05an = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    if ((ritter02an == true) & (ritter02ben == true) & (ritter02fertig == false))
                        ritter02an = false;
                    if ((ritter03an == true) & (ritter03ben == true) & (ritter03fertig == false))
                        ritter03an = false;
                    if ((ritter04an == true) & (ritter04ben == true) & (ritter04fertig == false))
                        ritter04an = false;
                    if ((ritter01an == true) & (ritter01ben == true) & (ritter01fertig == false))
                        ritter01an = false;
                    if ((ritter06an == true) & (ritter06ben == true) & (ritter06fertig == false))
                        ritter06an = false;
                    ritterzeichnen();
                }

            }
        }

        private void ritter06_Click(object sender, EventArgs e)
        {
            // Ritter bauen
            if ((ritter06an == true) & (ritter06ben == false))
            {
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_an;
                ritter = 6;
                ritter06an = false;
                ritter06ben = true;
                bauritter();
                bauen();
            }
            else
            // Ritter aktivieren andere deaktivieren
            {
                if ((ritter06an == false) & (ritter06ben == true))
                {
                    ritterjokan();
                    ritter06an = true;
                    pictureBox7.Enabled = true;
                    pictureBox8.Enabled = true;
                    pictureBox9.Enabled = true;
                    pictureBox10.Enabled = true;
                    pictureBox11.Enabled = true;
                    pictureBox12.Enabled = true;
                    if ((ritter02an == true) & (ritter02ben == true) & (ritter02fertig == false))
                        ritter02an = false;
                    if ((ritter03an == true) & (ritter03ben == true) & (ritter03fertig == false))
                        ritter03an = false;
                    if ((ritter04an == true) & (ritter04ben == true) & (ritter04fertig == false))
                        ritter04an = false;
                    if ((ritter05an == true) & (ritter05ben == true) & (ritter05fertig == false))
                        ritter05an = false;
                    if ((ritter01an == true) & (ritter01ben == true) & (ritter01fertig == false))
                        ritter01an = false;
                    ritterzeichnen();
                }

            }
        }

        private void strasse01_Click(object sender, EventArgs e)
        {
            strasse01.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 1;
            punkte = punkte + 1;
            baustrasse();
            bauen();
        }

        private void strasse02_Click(object sender, EventArgs e)
        {
            strasse02.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 2;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse03_Click(object sender, EventArgs e)
        {
            strasse03.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 3;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse04_Click(object sender, EventArgs e)
        {
            strasse04.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 4;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse05_Click(object sender, EventArgs e)
        {
            strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            strasse = 5;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse06_Click(object sender, EventArgs e)
        {
            strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 6;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse07_Click(object sender, EventArgs e)
        {
            strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 7;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse08_Click(object sender, EventArgs e)
        {
            strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 8;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse09_Click(object sender, EventArgs e)
        {
            strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 9;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void strasse10_Click(object sender, EventArgs e)
        {
            strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 10;
            punkte = punkte + 1; 
            baustrasse();
            bauen();
        }

        private void stastr01_Click(object sender, EventArgs e)
        {
            stastr01.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr1 = true;
            punkte = punkte + 1; 
            baustrasse();
            bauen();        
        }

        private void stastr02_Click(object sender, EventArgs e)
        {
            stastr02.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr2 = true;
            punkte = punkte + 1; 
            baustrasse();
            bauen();         
        }

        private void stastr03_Click(object sender, EventArgs e)
        {
            stastr03.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr = 1;
            punkte = punkte + 1; 
            baustrasse();
            bauen();        
        }

        private void stastr04_Click(object sender, EventArgs e)
        {
            stastr04.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            stastr = 2;
            punkte = punkte + 1; 
            baustrasse();
            bauen();         
        }

        private void stastr05_Click(object sender, EventArgs e)
        {
            stastr05.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            stastr = 3;
            punkte = punkte + 1; 
            baustrasse();
            bauen();         
        }

        private void stastr06_Click(object sender, EventArgs e)
        {
            stastr06.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr = 4;
            punkte = punkte + 1; 
            baustrasse();
            bauen();         
        }

        //Runde beenden Knopf, noch bearbeiten

        private void punkteschreiben()
        {
            if (rundenzahl == 1)
                runde1.Text = punkte.ToString();
            if (rundenzahl == 2)
                runde2.Text = punkte.ToString();
            if (rundenzahl == 3)
                runde3.Text = punkte.ToString();
            if (rundenzahl == 4)
                runde4.Text = punkte.ToString();
            if (rundenzahl == 5)
                runde5.Text = punkte.ToString();
            if (rundenzahl == 6)
                runde6.Text = punkte.ToString();
            if (rundenzahl == 7)
                runde7.Text = punkte.ToString();
            if (rundenzahl == 8)
                runde8.Text = punkte.ToString();
            if (rundenzahl == 9)
                runde9.Text = punkte.ToString();
            if (rundenzahl == 10)
                runde10.Text = punkte.ToString();
            if (rundenzahl == 11)
                runde11.Text = punkte.ToString();
            if (rundenzahl == 12)
                runde12.Text = punkte.ToString();
            if (rundenzahl == 13)
                runde13.Text = punkte.ToString();
            if (rundenzahl == 14)
                runde14.Text = punkte.ToString();
            if (rundenzahl == 15)
                runde15.Text = punkte.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            wuerf1 = 0;
            wuerf2 = 0;
            wuerf3 = 0;
            wuerf4 = 0;
            wuerf5 = 0;
            wuerf6 = 0;
            wuerf10 = 0;
            wuerf20 = 0;
            wuerf30 = 0;
            wuerf40 = 0;
            wuerf50 = 0;
            wuerf60 = 0;
            zeichnen();

            // if ((ritter01ben = true) & (ritter01fertig = false))
                //     ritter01an = false;
            // if ((ritter02ben = true) & (ritter02an = true) & (ritter02fertig = false))
                //    ritter02an = false;
            //if ((ritter03ben = true) & (ritter03an = true) & (ritter03fertig = false))
                //    ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_an;
            //if ((ritter04ben = true) & (ritter04an = true) & (ritter04fertig = false))
                //    ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_an;
            //if ((ritter05ben = true) & (ritter05an = true) & (ritter05fertig = false))
            //    ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_an;
            //if ((ritter06ben = true) & (ritter06an = true) & (ritter06fertig = false))
            //    ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_an;
            
            ritterzeichnen();
            wuerf1 = 1;
            wuerf2 = 1;
            wuerf3 = 1;
            wuerf4 = 1;
            wuerf5 = 1;
            wuerf6 = 1;
            ausschalten();
            if (punkte == 0)
                punkte = -2;
            punkteschreiben();
            rundenzahl = rundenzahl + 1;
            punkteges = punkteges + punkte;
            punkte = 0;
            if (rundenzahl < 16)
            {
                wuerfe = 3;
                label2.Text = wuerfe.ToString();
                button1.Enabled = true;
            }
            else
            {
                runde16.Text = punkteges.ToString();
                button1.Enabled = false;
                button2.Enabled = false;
                // copy & paste
                CheckHighScore();
                highScoreTable.Load(Application.StartupPath + @"\score.txt");
                HighScore HighScoreForm = new HighScore(highScoreTable);
                HighScoreForm.StartPosition = FormStartPosition.CenterScreen;
                HighScoreForm.Show();
                
            }

        }

        private void ritterauswahl1_Click(object sender, EventArgs e)
        {
            ritterjoker = 1;
            ritterjokaus();
        }

        private void ritterauswahl2_Click(object sender, EventArgs e)
        {
            ritterjoker = 2;
            ritterjokaus();
        }

        private void ritterauswahl3_Click(object sender, EventArgs e)
        {
            ritterjoker = 3;
            ritterjokaus();
        }

        private void ritterauswahl4_Click(object sender, EventArgs e)
        {
            ritterjoker = 4;
            ritterjokaus();
        }

        private void ritterauswahl5_Click(object sender, EventArgs e)
        {
            ritterjoker = 5;
            ritterjokaus();
        }

        private void runde7_Click(object sender, EventArgs e)
        {

        }

        private void runde6_Click(object sender, EventArgs e)
        {

        }

        private void runde5_Click(object sender, EventArgs e)
        {

        }


        //Runde beenden Knopf, noch bearbeiten
        


    }
}
