using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public int wuerf1 = 1;
        public int wuerf2 = 2;
        public int wuerf3 = 3;
        public int wuerf4 = 4;
        public int wuerf5 = 5;
        public int wuerf6 = 6;
        public int wuerfe = 3;
        public int gold = 0;

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
                if ((ritter01ben == true) & (ritter01an == true))
                {
                    wuerf10 = 5;
                    ritter01an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true))
                {
                    wuerf10 = 4;
                    ritter02an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true))
                {
                    wuerf10 = 3;
                    ritter03an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true))
                {
                    wuerf10 = 2;
                    ritter04an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true))
                {
                    wuerf10 = 1;
                    ritter05an = false;
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
                if ((ritter01ben == true) & (ritter01an == true))
                {
                    wuerf20 = 5;
                    ritter01an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true))
                {
                    wuerf20 = 4;
                    ritter02an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true))
                {
                    wuerf20 = 3;
                    ritter03an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true))
                {
                    wuerf20 = 2;
                    ritter04an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true))
                {
                    wuerf20 = 1;
                    ritter05an = false;
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
                if ((ritter01ben == true) & (ritter01an == true))
                {
                    wuerf30 = 5;
                    ritter01an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true))
                {
                    wuerf30 = 4;
                    ritter02an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true))
                {
                    wuerf30 = 3;
                    ritter03an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true))
                {
                    wuerf30 = 2;
                    ritter04an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true))
                {
                    wuerf30 = 1;
                    ritter05an = false;
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
                if ((ritter01ben == true) & (ritter01an == true))
                {
                    wuerf40 = 5;
                    ritter01an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true))
                {
                    wuerf40 = 4;
                    ritter02an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true))
                {
                    wuerf40 = 3;
                    ritter03an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true))
                {
                    wuerf40 = 2;
                    ritter04an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true))
                {
                    wuerf40 = 1;
                    ritter05an = false;
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
                if ((ritter01ben == true) & (ritter01an == true))
                {
                    wuerf50 = 5;
                    ritter01an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true))
                {
                    wuerf50 = 4;
                    ritter02an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true))
                {
                    wuerf50 = 3;
                    ritter03an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true))
                {
                    wuerf50 = 2;
                    ritter04an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true))
                {
                    wuerf50 = 1;
                    ritter05an = false;
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
                if ((ritter01ben == true) & (ritter01an == true))
                {
                    wuerf60 = 5;
                    ritter01an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter02ben == true) & (ritter02an == true))
                {
                    wuerf60 = 4;
                    ritter02an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter03ben == true) & (ritter03an == true))
                {
                    wuerf60 = 3;
                    ritter03an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter04ben == true) & (ritter04an == true))
                {
                    wuerf60 = 2;
                    ritter04an = false;
                    zeichnen();
                    bauen();
                }
                if ((ritter05ben == true) & (ritter05an == true))
                {
                    wuerf60 = 1;
                    ritter05an = false;
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
            if ((ritter01ben == true) & (ritter01an == true))
            {
                ritter01ben = false;
                ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_an;

            }
            if ((ritter02ben == true) & (ritter02an == true))
            {
                ritter02ben = false;
                ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_an;

            }
            if ((ritter03ben == true) & (ritter03an == true))
            {
                ritter03ben = false;
                ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_an;

            }
            if ((ritter04ben == true) & (ritter04an == true))
            {
                ritter04ben = false;
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_an;

            }
            if ((ritter05ben == true) & (ritter05an == true))
            {
                ritter05ben = false;
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_an;

            }
            if ((ritter06ben == true) & (ritter06an == true))
            {
                ritter06ben = false;
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_an;

            }
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
                    ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_an;
                else
                    ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_frei;

            if (ritter02ben == true)
                ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_ben;
            else
                if (ritter02an == true)
                    ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_an;
                else
                    ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_frei;

            if (ritter03ben == true)
                ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_ben;
            else
                if (ritter03an == true)
                    ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_an;
                else
                    ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_frei;

            if (ritter04ben == true)
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_ben;
            else
                if (ritter04an == true)
                    ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_an;
                else
                    ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_frei;

            if (ritter05ben == true)
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_ben;
            else
                if (ritter05an == true)
                    ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_an;
                else
                    ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_frei;

            if (ritter06ben == true)
                ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_ben;
            else
                if (ritter06an == true)
                    ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_an;
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

                if (ritter01an==true)
                    ritter01.Enabled = true;
                if (ritter02an == true)
                    ritter02.Enabled = true;
                if (ritter03an == true)
                    ritter03.Enabled = true;
                if (ritter04an == true)
                    ritter04.Enabled = true;
                if (ritter05an == true)
                    ritter05.Enabled = true;
                if (ritter06an == true)
                    ritter06.Enabled = true;

                //bauen aktivieren
                if ((erz > 0) & (schaaf > 0) & (getreide > 0))
                {
                    if ((ritter == 0) || (ritter01an == true))
                    {
                        ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_aus;
                        if (ritter01an == true)
                            ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_an;
                        ritter01.Enabled = true;
                    }
                    if ((ritter == 1) || (ritter02an == true))
                    {
                        ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_aus;
                        if (ritter02an == true)
                            ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_an;
                        ritter02.Enabled = true;
                    }
                    if ((ritter == 2) || (ritter03an == true))
                    {
                        ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_aus;
                        if (ritter03an == true)
                            ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_an;
                        ritter03.Enabled = true;
                    }
                    if ((ritter == 3) || (ritter04an == true))
                    {
                        ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_aus;
                        if (ritter04an == true)
                            ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_an;
                        ritter04.Enabled = true;
                    }
                    if ((ritter == 4) || (ritter05an == true))
                    {
                        ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_aus;
                        if (ritter05an == true)
                            ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_an; 
                        ritter05.Enabled = true;
                    }
                    if ((ritter == 5) || (ritter06an == true))
                    {
                        ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_aus;
                        if (ritter06an == true)
                            ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_an;
                        ritter06.Enabled = true;
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
                //if ((lehm > 0) & (holz > 0))
                //{
                //    strasse01.Visible = true;
                //    strasse01.Enabled = true;
                //}
            }
        }

        // Rohstoffreduzierung beim Bau
        
        public void baustadt()
        {
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
            if (ritter01an == false)
            {
                ritter01.Image = WindowsApplication1.Properties.Resources.ritter_01_an;
                ritter = 1;
                ritter01an = true;
                bauritter();
                bauen();
            }
            else
            {
                ritter01ben = true;
                ritter02ben = false;
                ritter03ben = false;
                ritter04ben = false;
                ritter05ben = false;
                ritter06ben = false;
                ritterzeichnen(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }
        }

        private void ritter02_Click(object sender, EventArgs e)
        {
            if (ritter02an == false)
            {
                ritter02.Image = WindowsApplication1.Properties.Resources.ritter_02_an;
                ritter = 2;
                ritter02an = true;
                bauritter();
                bauen();
            }
            else
            {
                ritter01ben = false;
                ritter02ben = true;
                ritter03ben = false;
                ritter04ben = false;
                ritter05ben = false;
                ritter06ben = false;
                ritterzeichnen(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void ritter03_Click(object sender, EventArgs e)
        {
            if (ritter03an == false)
            {
                ritter03.Image = WindowsApplication1.Properties.Resources.ritter_03_an;
                ritter = 3;
                ritter03an = true;
                bauritter();
                bauen();
            }
            else
            {
                ritter01ben = false;
                ritter02ben = false;
                ritter03ben = true;
                ritter04ben = false;
                ritter05ben = false;
                ritter06ben = false;
                ritterzeichnen(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void ritter04_Click(object sender, EventArgs e)
        {
            if (ritter04an == false)
            {
                ritter04.Image = WindowsApplication1.Properties.Resources.ritter_04_an;
                ritter = 4;
                ritter04an = true;
                bauritter();
                bauen();
            }
            else
            {
                ritter01ben = false;
                ritter02ben = false;
                ritter03ben = false;
                ritter04ben = true;
                ritter05ben = false;
                ritter06ben = false;
                ritterzeichnen(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void ritter05_Click(object sender, EventArgs e)
        {
            if (ritter05an == false)
            {
                ritter05.Image = WindowsApplication1.Properties.Resources.ritter_05_an;
                ritter = 5;
                ritter05an = true;
                bauritter();
                bauen();
            }
            else
            {
                ritter01ben = false;
                ritter02ben = false;
                ritter03ben = false;
                ritter04ben = false;
                ritter05ben = true;
                ritter06ben = false;
                ritterzeichnen();
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void ritter06_Click(object sender, EventArgs e)
        {
            ritter06.Image = WindowsApplication1.Properties.Resources.ritter_06_an;
            ritter = 6;
            ritter06an = true;
            bauritter();
            bauen();
        }

        private void strasse01_Click(object sender, EventArgs e)
        {
            strasse01.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 1;
            baustrasse();
            bauen();
        }

        private void strasse02_Click(object sender, EventArgs e)
        {
            strasse02.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 2;
            baustrasse();
            bauen();
        }

        private void strasse03_Click(object sender, EventArgs e)
        {
            strasse03.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 3;
            baustrasse();
            bauen();
        }

        private void strasse04_Click(object sender, EventArgs e)
        {
            strasse04.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 4;
            baustrasse();
            bauen();
        }

        private void strasse05_Click(object sender, EventArgs e)
        {
            strasse05.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            strasse = 5;
            baustrasse();
            bauen();
        }

        private void strasse06_Click(object sender, EventArgs e)
        {
            strasse06.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 6;
            baustrasse();
            bauen();
        }

        private void strasse07_Click(object sender, EventArgs e)
        {
            strasse07.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 7;
            baustrasse();
            bauen();
        }

        private void strasse08_Click(object sender, EventArgs e)
        {
            strasse08.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 8;
            baustrasse();
            bauen();
        }

        private void strasse09_Click(object sender, EventArgs e)
        {
            strasse09.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            strasse = 9;
            baustrasse();
            bauen();
        }

        private void strasse10_Click(object sender, EventArgs e)
        {
            strasse10.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            strasse = 10;
            baustrasse();
            bauen();
        }

        private void stastr01_Click(object sender, EventArgs e)
        {
            stastr01.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr1 = true;
            baustrasse();
            bauen();        
        }

        private void stastr02_Click(object sender, EventArgs e)
        {
            stastr02.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr2 = true;
            baustrasse();
            bauen();         
        }

        private void stastr03_Click(object sender, EventArgs e)
        {
            stastr03.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr = 1;
            baustrasse();
            bauen();        
        }

        private void stastr04_Click(object sender, EventArgs e)
        {
            stastr04.Image = WindowsApplication1.Properties.Resources.strasse_30_an;
            stastr = 2;
            baustrasse();
            bauen();         
        }

        private void stastr05_Click(object sender, EventArgs e)
        {
            stastr05.Image = WindowsApplication1.Properties.Resources.strasse_120_an;
            stastr = 3;
            baustrasse();
            bauen();         
        }

        private void stastr06_Click(object sender, EventArgs e)
        {
            stastr06.Image = WindowsApplication1.Properties.Resources.strasse_90_an;
            stastr = 4;
            baustrasse();
            bauen();         
        }

        //Runde beenden Knopf, noch bearbeiten

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
            wuerf1 = 1;
            wuerf2 = 1;
            wuerf3 = 1;
            wuerf4 = 1;
            wuerf5 = 1;
            wuerf6 = 1;
            ausschalten();
            button1.Enabled = true;
            wuerfe = 3;
            label2.Text = wuerfe.ToString();
        }






        //Runde beenden Knopf, noch bearbeiten
        


    }
}
