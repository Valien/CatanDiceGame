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
        public int dice1 = 1; //dice 1
        public int dice2 = 2;
        public int dice3 = 3;
        public int dice4 = 4;
        public int dice5 = 5;
        public int dice6 = 6;
        public int dicee = 3;
        public int gold = 0;

        public int dice10 = 0;
        public int dice20 = 0;
        public int dice30 = 0;
        public int dice40 = 0;
        public int dice50 = 0;
        public int dice60 = 0;
        
        public int city = 0; //city
        public int settlement = 0; //settlement
        public int knight = 0; //knight
        public int road = 0; //road
        public int stastr = 0;
        public bool stastr1 = false;
        public bool stastr2 = false;
        public bool built = false; //built

        public bool knight01an = false; //knight on
        public bool knight01ben = false;
        public bool knight02an = false;
        public bool knight02ben = false;
        public bool knight03an = false;
        public bool knight03ben = false;
        public bool knight04an = false;
        public bool knight04ben = false;
        public bool knight05an = false;
        public bool knight05ben = false;
        public bool knight06an = false;
        public bool knight06ben = false;

        public int brick = 0; //brick
        public int wood = 0; //wood
        public int schaaf = 0;
        public int grain = 0; //grain
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
            knight01.Enabled = false;
            city01.Enabled = false;
            settlement01.Enabled = false;
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
            if (dice1 > 0)
                dice1 = rnd.Next(1, 7);
            
            if (dice2 > 0)
                dice2 = rnd.Next(1, 7);
            
            if (dice3 > 0)
                dice3 = rnd.Next(1, 7);
            
            if (dice4 > 0)
                dice4 = rnd.Next(1, 7);
            
            if (dice5 > 0)
                dice5 = rnd.Next(1, 7);
            
            if (dice6 > 0)
                dice6 = rnd.Next(1, 7);
            draw();
            dicee = dicee - 1;
            label2.Text = dicee.ToString();
            if (dicee == 0)
            {
                button1.Enabled = false;
                wurfbeenden.Enabled = false;
                if (dice10 == 0)
                {
                    dice10 = dice1;
                    dice1 = 0;
                    draw();
                }
                if (dice20 == 0)
                {
                    dice20 = dice2;
                    dice2 = 0;
                    draw();
                }
                if (dice30 == 0)
                {
                    dice30 = dice3;
                    dice3 = 0;
                    draw();
                }
                if (dice40 == 0)
                {
                    dice40 = dice4;
                    dice4 = 0;
                    draw();    
                }
                if (dice50 == 0)
                {
                    dice50 = dice5;
                    dice5 = 0;
                    draw();    
                }
                if (dice60 == 0)
                {
                    dice60 = dice6;
                    dice6 = 0;
                    draw();
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
                build();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dicee < 3)
            {
                if (dice1 > 0)
                    dice10 = dice1;
                dice1 = 0;
                draw();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (dice10 > 0)
            {
                if ((knight01ben == true) & (knight01an == true))
                {
                    dice10 = 5;
                    knight01an = false;
                    draw();
                    build();
                }
                if ((knight02ben == true) & (knight02an == true))
                {
                    dice10 = 4;
                    knight02an = false;
                    draw();
                    build();
                }
                if ((knight03ben == true) & (knight03an == true))
                {
                    dice10 = 3;
                    knight03an = false;
                    draw();
                    build();
                }
                if ((knight04ben == true) & (knight04an == true))
                {
                    dice10 = 2;
                    knight04an = false;
                    draw();
                    build();
                }
                if ((knight05ben == true) & (knight05an == true))
                {
                    dice10 = 1;
                    knight05an = false;
                    draw();
                    build();
                }
                if ((dice10 > 0) & (dicee > 0))
                {
                    dice1 = dice10;
                    dice10 = 0;
                    draw();
                }
            }
            else
                knightaus();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dicee < 3)
            {
                if (dice2 > 0)
                    dice20 = dice2;
                dice2 = 0;
                draw();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (dice20 > 0)
            {
                if ((knight01ben == true) & (knight01an == true))
                {
                    dice20 = 5;
                    knight01an = false;
                    draw();
                    build();
                }
                if ((knight02ben == true) & (knight02an == true))
                {
                    dice20 = 4;
                    knight02an = false;
                    draw();
                    build();
                }
                if ((knight03ben == true) & (knight03an == true))
                {
                    dice20 = 3;
                    knight03an = false;
                    draw();
                    build();
                }
                if ((knight04ben == true) & (knight04an == true))
                {
                    dice20 = 2;
                    knight04an = false;
                    draw();
                    build();
                }
                if ((knight05ben == true) & (knight05an == true))
                {
                    dice20 = 1;
                    knight05an = false;
                    draw();
                    build();
                }
                if ((dice20 > 0) & (dicee > 0))
                {
                    dice2 = dice20;
                    dice20 = 0;
                    draw();
                }
            }
            else
                knightaus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dicee < 3)
            {
                if (dice3 > 0)
                    dice30 = dice3;
                dice3 = 0;
                draw();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (dice30 > 0)
            {
                if ((knight01ben == true) & (knight01an == true))
                {
                    dice30 = 5;
                    knight01an = false;
                    draw();
                    build();
                }
                if ((knight02ben == true) & (knight02an == true))
                {
                    dice30 = 4;
                    knight02an = false;
                    draw();
                    build();
                }
                if ((knight03ben == true) & (knight03an == true))
                {
                    dice30 = 3;
                    knight03an = false;
                    draw();
                    build();
                }
                if ((knight04ben == true) & (knight04an == true))
                {
                    dice30 = 2;
                    knight04an = false;
                    draw();
                    build();
                }
                if ((knight05ben == true) & (knight05an == true))
                {
                    dice30 = 1;
                    knight05an = false;
                    draw();
                    build();
                }
                if ((dice30 > 0) & (dicee > 0))
                {
                    dice3 = dice30;
                    dice30 = 0;
                    draw();
                }
            }
            else
                knightaus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dicee < 3)
            {
                if (dice4 > 0)
                    dice40 = dice4;
                dice4 = 0;
                draw();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (dice40 > 0)
            {
                if ((knight01ben == true) & (knight01an == true))
                {
                    dice40 = 5;
                    knight01an = false;
                    draw();
                    build();
                }
                if ((knight02ben == true) & (knight02an == true))
                {
                    dice40 = 4;
                    knight02an = false;
                    draw();
                    build();
                }
                if ((knight03ben == true) & (knight03an == true))
                {
                    dice40 = 3;
                    knight03an = false;
                    draw();
                    build();
                }
                if ((knight04ben == true) & (knight04an == true))
                {
                    dice40 = 2;
                    knight04an = false;
                    draw();
                    build();
                }
                if ((knight05ben == true) & (knight05an == true))
                {
                    dice40 = 1;
                    knight05an = false;
                    draw();
                    build();
                }
                if ((dice40 > 0) & (dicee > 0))
                {
                    dice4 = dice40;
                    dice40 = 0;
                    draw();
                }
            }
            else
                knightaus();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (dicee < 3)
            {
                if (dice5 > 0)
                    dice50 = dice5;
                dice5 = 0;
                draw();
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (dice50 > 0)
            {
                if ((knight01ben == true) & (knight01an == true))
                {
                    dice50 = 5;
                    knight01an = false;
                    draw();
                    build();
                }
                if ((knight02ben == true) & (knight02an == true))
                {
                    dice50 = 4;
                    knight02an = false;
                    draw();
                    build();
                }
                if ((knight03ben == true) & (knight03an == true))
                {
                    dice50 = 3;
                    knight03an = false;
                    draw();
                    build();
                }
                if ((knight04ben == true) & (knight04an == true))
                {
                    dice50 = 2;
                    knight04an = false;
                    draw();
                    build();
                }
                if ((knight05ben == true) & (knight05an == true))
                {
                    dice50 = 1;
                    knight05an = false;
                    draw();
                    build();
                }
                if ((dice50 > 0) & (dicee > 0))
                {
                    dice5 = dice50;
                    dice50 = 0;
                    draw();
                }

            }
            else
                knightaus();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (dicee < 3)
            {
                if (dice6 > 0)
                    dice60 = dice6;
                dice6 = 0;
                draw();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (dice60 > 0)
            {
                if ((knight01ben == true) & (knight01an == true))
                {
                    dice60 = 5;
                    knight01an = false;
                    draw();
                    build();
                }
                if ((knight02ben == true) & (knight02an == true))
                {
                    dice60 = 4;
                    knight02an = false;
                    draw();
                    build();
                }
                if ((knight03ben == true) & (knight03an == true))
                {
                    dice60 = 3;
                    knight03an = false;
                    draw();
                    build();
                }
                if ((knight04ben == true) & (knight04an == true))
                {
                    dice60 = 2;
                    knight04an = false;
                    draw();
                    build();
                }
                if ((knight05ben == true) & (knight05an == true))
                {
                    dice60 = 1;
                    knight05an = false;
                    draw();
                    build();
                }
                if ((dice60 > 0) & (dicee > 0))
                {
                    dice6 = dice60;
                    dice60 = 0;
                    draw();
                }
            }
            else
                knightaus();
        }

        private void knightaus()
        {
            if ((knight01ben == true) & (knight01an == true))
            {
                knight01ben = false;
                knight01.Image = WindowsApplication1.Properties.Resources.knight_01_an;

            }
            if ((knight02ben == true) & (knight02an == true))
            {
                knight02ben = false;
                knight02.Image = WindowsApplication1.Properties.Resources.knight_02_an;

            }
            if ((knight03ben == true) & (knight03an == true))
            {
                knight03ben = false;
                knight03.Image = WindowsApplication1.Properties.Resources.knight_03_an;

            }
            if ((knight04ben == true) & (knight04an == true))
            {
                knight04ben = false;
                knight04.Image = WindowsApplication1.Properties.Resources.knight_04_an;

            }
            if ((knight05ben == true) & (knight05an == true))
            {
                knight05ben = false;
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_an;

            }
            if ((knight06ben == true) & (knight06an == true))
            {
                knight06ben = false;
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_an;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
                if (dice10 == 0)
                {
                    dice10 = dice1;
                    dice1 = 0;
                 }
                if (dice20 == 0)
                {
                    dice20 = dice2;
                    dice2 = 0;
                 }
                if (dice30 == 0)
                {
                    dice30 = dice3;
                    dice3 = 0;
                }
                if (dice40 == 0)
                {
                    dice40 = dice4;
                    dice4 = 0;
                 }
                if (dice50 == 0)
                {
                    dice50 = dice5;
                    dice5 = 0;
                 }
                if (dice60 == 0)
                {
                    dice60 = dice6;
                    dice6 = 0;
                }
                draw();
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
                build();
            }

        //Gold auswählen

        private void picgold1_Click(object sender, EventArgs e)
        {
            if (dice10 == 6)
            {
                dice10 = 1;
                if (dice20 == 6)
                    dice20 = 0;
                else
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
            }
            else
                if (dice20 == 6)
                {
                    dice20 = 1;
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                }
                else
                    if (dice30 == 6)
                    {
                        dice30 = 1;
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                    }
                    else
                        if (dice40 == 6)
                        {
                            dice40 = 1;
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                        }
                        else
                            if (dice50 == 6)
                            {
                                dice50 = 1;
                                dice60 = 0;
                            }
            draw();
            build();
        }

        private void picgold2_Click(object sender, EventArgs e)
        {
            if (dice10 == 6)
            {
                dice10 = 2;
                if (dice20 == 6)
                    dice20 = 0;
                else
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
            }
            else
                if (dice20 == 6)
                {
                    dice20 = 2;
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                }
                else
                    if (dice30 == 6)
                    {
                        dice30 = 2;
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                    }
                    else
                        if (dice40 == 6)
                        {
                            dice40 = 2;
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                        }
                        else
                            if (dice50 == 6)
                            {
                                dice50 = 2;
                                dice60 = 0;
                            }
            draw();
            build();
        }

        private void picgold3_Click(object sender, EventArgs e)
        {
            if (dice10 == 6)
            {
                dice10 = 3;
                if (dice20 == 6)
                    dice20 = 0;
                else
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
            }
            else
                if (dice20 == 6)
                {
                    dice20 = 3;
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                }
                else
                    if (dice30 == 6)
                    {
                        dice30 = 3;
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                    }
                    else
                        if (dice40 == 6)
                        {
                            dice40 = 3;
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                        }
                        else
                            if (dice50 == 6)
                            {
                                dice50 = 3;
                                dice60 = 0;
                            }
            draw();
            build();
        }

        private void picgold4_Click(object sender, EventArgs e)
        {
            if (dice10 == 6)
            {
                dice10 = 4;
                if (dice20 == 6)
                    dice20 = 0;
                else
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
            }
            else
                if (dice20 == 6)
                {
                    dice20 = 4;
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                }
                else
                    if (dice30 == 6)
                    {
                        dice30 = 4;
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                    }
                    else
                        if (dice40 == 6)
                        {
                            dice40 = 4;
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                        }
                        else
                            if (dice50 == 6)
                            {
                                dice50 = 4;
                                dice60 = 0;
                            }
            draw();
            build();
        }

        private void picgold5_Click(object sender, EventArgs e)
        {
           if (dice10 == 6)
           {
                    dice10 = 5;
               if (dice20 == 6)
                   dice20 = 0;
               else
                    if (dice30 == 6)
                        dice30 = 0;
                    else
                        if (dice40 == 6)
                            dice40 = 0;
                        else
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
           }
           else
               if (dice20 == 6)
               {
                   dice20 = 5;
                   if (dice30 == 6)
                       dice30 = 0;
                   else
                       if (dice40 == 6)
                           dice40 = 0;
                       else
                           if (dice50 == 6)
                               dice50 = 0;
                           else
                               if (dice60 == 6)
                                   dice60 = 0;
               }
               else
                   if (dice30 == 6)
                   {
                       dice30 = 5;
                       if (dice40 == 6)
                           dice40 = 0;
                       else
                           if (dice50 == 6)
                               dice50 = 0;
                           else
                               if (dice60 == 6)
                                   dice60 = 0;
                   }
                   else
                        if (dice40 == 6)
                        {
                            dice40 = 5;
                            if (dice50 == 6)
                                dice50 = 0;
                            else
                                if (dice60 == 6)
                                    dice60 = 0;
                        }
                        else
                            if (dice50 == 6)
                            {
                                dice50 = 5;
                                dice60 = 0;
                            }
            draw();
            build();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        // Zeichen- und Baufunktion
        
        public void draw()
        {
            //diceel unten
            if (dice1 == 0)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice1 == 1)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice1 == 2)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice1 == 3)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice1 == 4)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice1 == 5)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice1 == 6)
                pictureBox1.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice2 == 0)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice2 == 1)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice2 == 2)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice2 == 3)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice2 == 4)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice2 == 5)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice2 == 6)
                pictureBox2.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice3 == 0)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice3 == 1)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice3 == 2)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice3 == 3)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice3 == 4)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice3 == 5)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice3 == 6)
                pictureBox3.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice4 == 0)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.blank;            
            if (dice4 == 1)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice4 == 2)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice4 == 3)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice4 == 4)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice4 == 5)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice4 == 6)
                pictureBox4.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice5 == 0)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice5 == 1)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice5 == 2)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice5 == 3)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice5 == 4)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice5 == 5)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice5 == 6)
                pictureBox5.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice6 == 0)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice6 == 1)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice6 == 2)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice6 == 3)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice6 == 4)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice6 == 5)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice6 == 6)
                pictureBox6.Image = WindowsApplication1.Properties.Resources.gold6;

            //diceel oben
            if (dice10 == 0)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice10 == 1)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice10 == 2)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice10 == 3)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice10 == 4)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice10 == 5)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice10 == 6)
                pictureBox7.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice20 == 0)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice20 == 1)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice20 == 2)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice20 == 3)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice20 == 4)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice20 == 5)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice20 == 6)
                pictureBox8.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice30 == 0)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice30 == 1)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice30 == 2)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice30 == 3)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice30 == 4)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice30 == 5)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice30 == 6)
                pictureBox9.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice40 == 0)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice40 == 1)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice40 == 2)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice40 == 3)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice40 == 4)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice40 == 5)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice40 == 6)
                pictureBox10.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice50 == 0)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice50 == 1)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice50 == 2)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice50 == 3)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice50 == 4)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice50 == 5)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice50 == 6)
                pictureBox11.Image = WindowsApplication1.Properties.Resources.gold6;

            if (dice60 == 0)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.blank;
            if (dice60 == 1)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.wood1;
            if (dice60 == 2)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.brick2;
            if (dice60 == 3)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.schaaf3;
            if (dice60 == 4)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.grain4;
            if (dice60 == 5)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.erz5;
            if (dice60 == 6)
                pictureBox12.Image = WindowsApplication1.Properties.Resources.gold6;        
        }

        private void knightdraw()
        {
            if (knight01ben == true)
                if (knight01an == true)
                    knight01.Image = WindowsApplication1.Properties.Resources.knight_01_ben;
                else
                    knight01.Image = WindowsApplication1.Properties.Resources.knight_01_an;
            else
                if (knight01an == true)
                    knight01.Image = WindowsApplication1.Properties.Resources.knight_01_an;
                else
                    knight01.Image = WindowsApplication1.Properties.Resources.knight_01_frei;

            if (knight02ben == true)
                knight02.Image = WindowsApplication1.Properties.Resources.knight_02_ben;
            else
                if (knight02an == true)
                    knight02.Image = WindowsApplication1.Properties.Resources.knight_02_an;
                else
                    knight02.Image = WindowsApplication1.Properties.Resources.knight_02_frei;

            if (knight03ben == true)
                knight03.Image = WindowsApplication1.Properties.Resources.knight_03_ben;
            else
                if (knight03an == true)
                    knight03.Image = WindowsApplication1.Properties.Resources.knight_03_an;
                else
                    knight03.Image = WindowsApplication1.Properties.Resources.knight_03_frei;

            if (knight04ben == true)
                knight04.Image = WindowsApplication1.Properties.Resources.knight_04_ben;
            else
                if (knight04an == true)
                    knight04.Image = WindowsApplication1.Properties.Resources.knight_04_an;
                else
                    knight04.Image = WindowsApplication1.Properties.Resources.knight_04_frei;

            if (knight05ben == true)
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_ben;
            else
                if (knight05an == true)
                    knight05.Image = WindowsApplication1.Properties.Resources.knight_05_an;
                else
                    knight05.Image = WindowsApplication1.Properties.Resources.knight_05_frei;

            if (knight06ben == true)
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_ben;
            else
                if (knight06an == true)
                    knight06.Image = WindowsApplication1.Properties.Resources.knight_06_an;
                else
                    knight06.Image = WindowsApplication1.Properties.Resources.knight_06_frei;
        }

        public void ausschalten() //off
        {
            city01.Enabled = false;
            city02.Enabled = false;
            city03.Enabled = false;
            city04.Enabled = false;

            settlement01.Enabled = false;
            settlement02.Enabled = false;
            settlement03.Enabled = false;
            settlement04.Enabled = false;
            settlement05.Enabled = false;
            settlement06.Enabled = false;

            knight01.Enabled = false;
            knight02.Enabled = false;
            knight03.Enabled = false;
            knight04.Enabled = false;
            knight05.Enabled = false;
            knight06.Enabled = false;

            road01.Enabled = false;
            road02.Enabled = false;
            road03.Enabled = false;
            road04.Enabled = false;
            road05.Enabled = false;
            road06.Enabled = false;
            road07.Enabled = false;
            road08.Enabled = false;
            road09.Enabled = false;
            road10.Enabled = false;

            stastr01.Enabled = false;
            stastr02.Enabled = false;
            stastr03.Enabled = false;
            stastr04.Enabled = false;
            stastr05.Enabled = false;
            stastr06.Enabled = false;

            if (city == 0)
            {
                city01.Image = WindowsApplication1.Properties.Resources.city_01_frei; //free-ly
                city02.Image = WindowsApplication1.Properties.Resources.city_02_frei;
                city03.Image = WindowsApplication1.Properties.Resources.city_03_frei;
                city04.Image = WindowsApplication1.Properties.Resources.city_04_frei;
            }
            if (city == 1)
            {
                city02.Image = WindowsApplication1.Properties.Resources.city_02_frei;
                city03.Image = WindowsApplication1.Properties.Resources.city_03_frei;
                city04.Image = WindowsApplication1.Properties.Resources.city_04_frei;
            }
            if (city == 2)
            {
                city03.Image = WindowsApplication1.Properties.Resources.city_03_frei;
                city04.Image = WindowsApplication1.Properties.Resources.city_04_frei;
            }
            if (city == 3)
            {
                city04.Image = WindowsApplication1.Properties.Resources.city_04_frei;
            }
            if (settlement == 0)
            {
                settlement01.Image = WindowsApplication1.Properties.Resources.haus_01_frei;
                settlement02.Image = WindowsApplication1.Properties.Resources.haus_02_frei;
                settlement03.Image = WindowsApplication1.Properties.Resources.haus_03_frei;
                settlement04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                settlement05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (settlement == 1)
            {
                settlement02.Image = WindowsApplication1.Properties.Resources.haus_02_frei; //house
                settlement03.Image = WindowsApplication1.Properties.Resources.haus_03_frei;
                settlement04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                settlement05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (settlement == 2)
            {
                settlement03.Image = WindowsApplication1.Properties.Resources.haus_03_frei;
                settlement04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                settlement05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (settlement == 3)
            {
                settlement04.Image = WindowsApplication1.Properties.Resources.haus_04_frei;
                settlement05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (settlement == 4)
            {
                settlement05.Image = WindowsApplication1.Properties.Resources.haus_05_frei;
                settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (settlement == 5)
            {
                settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_frei;
            }
            if (knight == 0)
            {
                knight01.Image = WindowsApplication1.Properties.Resources.knight_01_frei;
                knight02.Image = WindowsApplication1.Properties.Resources.knight_02_frei;
                knight03.Image = WindowsApplication1.Properties.Resources.knight_03_frei;
                knight04.Image = WindowsApplication1.Properties.Resources.knight_04_frei;
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_frei;
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_frei;
            }
            if (knight == 1)
            {
                knight02.Image = WindowsApplication1.Properties.Resources.knight_02_frei;
                knight03.Image = WindowsApplication1.Properties.Resources.knight_03_frei;
                knight04.Image = WindowsApplication1.Properties.Resources.knight_04_frei;
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_frei;
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_frei;
            }
            if (knight == 2)
            {
                knight03.Image = WindowsApplication1.Properties.Resources.knight_03_frei;
                knight04.Image = WindowsApplication1.Properties.Resources.knight_04_frei;
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_frei;
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_frei;
            }
            if (knight == 3)
            {
                knight04.Image = WindowsApplication1.Properties.Resources.knight_04_frei;
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_frei;
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_frei;
            }
            if (knight == 4)
            {
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_frei;
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_frei;
            }
            if (knight == 5)
            {
                knight06.Image = WindowsApplication1.Properties.Resources.knight_06_frei;
            }

            if (road == 0)
            {
                road01.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road02.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road03.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road04.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road05.Image = WindowsApplication1.Properties.Resources.road_90_frei;
                road06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road07.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 1)
            {
                road02.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road03.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road04.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road05.Image = WindowsApplication1.Properties.Resources.road_90_frei;
                road06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road07.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 2)
            {
                road03.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road04.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road05.Image = WindowsApplication1.Properties.Resources.road_90_frei;
                road06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road07.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 3)
            {
                road04.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road05.Image = WindowsApplication1.Properties.Resources.road_90_frei;
                road06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road07.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 4)
            {
                road05.Image = WindowsApplication1.Properties.Resources.road_90_frei;
                road06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road07.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 5)
            {
                road06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road07.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 6)
            {
                road07.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 7)
            {
                road08.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 8)
            {
                road09.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (road == 9)
            {
                road10.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }

            if (stastr == 0)
            {
                stastr03.Image = WindowsApplication1.Properties.Resources.road_90_frei;
                stastr04.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                stastr05.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                stastr06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (stastr == 1)
            {
                stastr04.Image = WindowsApplication1.Properties.Resources.road_30_frei;
                stastr05.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                stastr06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (stastr == 2)
            {
                stastr05.Image = WindowsApplication1.Properties.Resources.road_120_frei;
                stastr06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (stastr == 3)
            {
                stastr06.Image = WindowsApplication1.Properties.Resources.road_30_frei;
            }
            if (stastr1 == false)
            {
                stastr01.Image = WindowsApplication1.Properties.Resources.road_90_frei;
            }
            if (stastr2 == false)
            {
                stastr02.Image = WindowsApplication1.Properties.Resources.road_90_frei;
            }
        }

        public void build()
        {
            //Gold umwandeln
            gold = 0;
            if (dice10 == 6)
                gold = gold + 1;
            if (dice20 == 6)
                gold = gold + 1;
            if (dice30 == 6)
                gold = gold + 1;
            if (dice40 == 6)
                gold = gold + 1;
            if (dice50 == 6)
                gold = gold + 1;
            if (dice60 == 6)
                gold = gold + 1;
            if (gold > 1)
            {
                picgold1.Enabled = true;
                picgold2.Enabled = true;
                picgold3.Enabled = true;
                picgold4.Enabled = true;
                picgold5.Enabled = true;
                picgold1.Image = WindowsApplication1.Properties.Resources.wood1;
                picgold2.Image = WindowsApplication1.Properties.Resources.brick2;
                picgold3.Image = WindowsApplication1.Properties.Resources.schaaf3;
                picgold4.Image = WindowsApplication1.Properties.Resources.grain4;
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
                draw();
                wood = 0;
                brick = 0;
                schaaf = 0;
                grain = 0;
                erz = 0;
                if (dice10 == 1)
                    brick = brick + 1;
                if (dice20 == 1)
                    brick = brick + 1;
                if (dice30 == 1)
                    brick = brick + 1;
                if (dice40 == 1)
                    brick = brick + 1;
                if (dice50 == 1)
                    brick = brick + 1;
                if (dice60 == 1)
                    brick = brick + 1;

                if (dice10 == 2)
                    wood = wood + 1;
                if (dice20 == 2)
                    wood = wood + 1;
                if (dice30 == 2)
                    wood = wood + 1;
                if (dice40 == 2)
                    wood = wood + 1;
                if (dice50 == 2)
                    wood = wood + 1;
                if (dice60 == 2)
                    wood = wood + 1;

                if (dice10 == 3)
                    schaaf = schaaf + 1;
                if (dice20 == 3)
                    schaaf = schaaf + 1;
                if (dice30 == 3)
                    schaaf = schaaf + 1;
                if (dice40 == 3)
                    schaaf = schaaf + 1;
                if (dice50 == 3)
                    schaaf = schaaf + 1;
                if (dice60 == 3)
                    schaaf = schaaf + 1;

                if (dice10 == 4)
                    grain = grain + 1;
                if (dice20 == 4)
                    grain = grain + 1;
                if (dice30 == 4)
                    grain = grain + 1;
                if (dice40 == 4)
                    grain = grain + 1;
                if (dice50 == 4)
                    grain = grain + 1;
                if (dice60 == 4)
                    grain = grain + 1;

                if (dice10 == 5)
                    erz = erz + 1;
                if (dice20 == 5)
                    erz = erz + 1;
                if (dice30 == 5)
                    erz = erz + 1;
                if (dice40 == 5)
                    erz = erz + 1;
                if (dice50 == 5)
                    erz = erz + 1;
                if (dice60 == 5)
                    erz = erz + 1;

                if (knight01an==true)
                    knight01.Enabled = true;
                if (knight02an == true)
                    knight02.Enabled = true;
                if (knight03an == true)
                    knight03.Enabled = true;
                if (knight04an == true)
                    knight04.Enabled = true;
                if (knight05an == true)
                    knight05.Enabled = true;
                if (knight06an == true)
                    knight06.Enabled = true;

                //build aktivieren
                if ((erz > 0) & (schaaf > 0) & (grain > 0))
                {
                    if ((knight == 0) || (knight01an == true))
                    {
                        knight01.Image = WindowsApplication1.Properties.Resources.knight_01_aus;
                        if (knight01an == true)
                            knight01.Image = WindowsApplication1.Properties.Resources.knight_01_an;
                        knight01.Enabled = true;
                    }
                    if ((knight == 1) || (knight02an == true))
                    {
                        knight02.Image = WindowsApplication1.Properties.Resources.knight_02_aus;
                        if (knight02an == true)
                            knight02.Image = WindowsApplication1.Properties.Resources.knight_02_an;
                        knight02.Enabled = true;
                    }
                    if ((knight == 2) || (knight03an == true))
                    {
                        knight03.Image = WindowsApplication1.Properties.Resources.knight_03_aus;
                        if (knight03an == true)
                            knight03.Image = WindowsApplication1.Properties.Resources.knight_03_an;
                        knight03.Enabled = true;
                    }
                    if ((knight == 3) || (knight04an == true))
                    {
                        knight04.Image = WindowsApplication1.Properties.Resources.knight_04_aus;
                        if (knight04an == true)
                            knight04.Image = WindowsApplication1.Properties.Resources.knight_04_an;
                        knight04.Enabled = true;
                    }
                    if ((knight == 4) || (knight05an == true))
                    {
                        knight05.Image = WindowsApplication1.Properties.Resources.knight_05_aus;
                        if (knight05an == true)
                            knight05.Image = WindowsApplication1.Properties.Resources.knight_05_an; 
                        knight05.Enabled = true;
                    }
                    if ((knight == 5) || (knight06an == true))
                    {
                        knight06.Image = WindowsApplication1.Properties.Resources.knight_06_aus;
                        if (knight06an == true)
                            knight06.Image = WindowsApplication1.Properties.Resources.knight_06_an;
                        knight06.Enabled = true;
                    }                  
                }
                if ((brick > 0) & (wood> 0) & (schaaf > 0) & (grain > 0))
                {
                    if (settlement == 0)
                    {
                        settlement01.Image = WindowsApplication1.Properties.Resources.haus_01_aus; ;
                        settlement01.Enabled = true;
                    }
                    if ((settlement == 1)&(road>1))
                    {
                        settlement02.Image = WindowsApplication1.Properties.Resources.haus_02_aus; ;
                        settlement02.Enabled = true;
                    }
                    if ((settlement == 2)&(road>3))
                    {
                        settlement03.Image = WindowsApplication1.Properties.Resources.haus_03_aus; ;
                        settlement03.Enabled = true;
                    }
                    if ((settlement == 3)&(road>5))
                    {
                        settlement04.Image = WindowsApplication1.Properties.Resources.haus_04_aus; ;
                        settlement04.Enabled = true;
                    }
                    if ((settlement == 4)&(road>7))
                    {
                        settlement05.Image = WindowsApplication1.Properties.Resources.haus_05_aus; ;
                        settlement05.Enabled = true;
                    }
                    if ((settlement == 5)&(road>9))
                    {
                        settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_aus; ;
                        settlement06.Enabled = true;
                    }

                }
                if ((erz > 2) & (grain > 1))
                {
                    if ((city == 0) & (stastr1 == true))
                    {
                        city01.Image = WindowsApplication1.Properties.Resources.city_01_aus;
                        city01.Enabled = true;
                    }
                    if ((city == 1) & (stastr2 == true))
                    {
                        city02.Image = WindowsApplication1.Properties.Resources.city_02_aus;
                        city02.Enabled = true;
                    }
                    if ((city == 2) & (stastr > 1))
                    {
                        city03.Image = WindowsApplication1.Properties.Resources.city_03_aus;
                        city03.Enabled = true;
                    }
                    if ((city == 3) & (stastr > 3))
                    {
                        city04.Image = WindowsApplication1.Properties.Resources.city_04_aus;
                        city04.Enabled = true;
                    }
                }
                if ((brick > 0) & (wood > 0))
                {
                    if (road == 0)
                    {
                        road01.Image = WindowsApplication1.Properties.Resources.road_30_aus;
                        road01.Enabled = true;
                    }
                    if (road == 1)
                    {
                        road02.Image = WindowsApplication1.Properties.Resources.road_120_aus;
                        road02.Enabled = true;
                    }
                    if (road == 2)
                    {
                        road03.Image = WindowsApplication1.Properties.Resources.road_30_aus;
                        road03.Enabled = true;
                    }
                    if (road == 3)
                    {
                        road04.Image = WindowsApplication1.Properties.Resources.road_120_aus;
                        road04.Enabled = true;
                    }
                    if (road == 4)
                    {
                        road05.Image = WindowsApplication1.Properties.Resources.road_90_aus;
                        road05.Enabled = true;
                    }
                    if (road == 5)
                    {
                        road06.Image = WindowsApplication1.Properties.Resources.road_30_aus;
                        road06.Enabled = true;
                    }
                    if (road == 6)
                    {
                        road07.Image = WindowsApplication1.Properties.Resources.road_120_aus;
                        road07.Enabled = true;
                    }
                    if (road == 7)
                    {
                        road08.Image = WindowsApplication1.Properties.Resources.road_30_aus;
                        road08.Enabled = true;
                    }
                    if (road == 8)
                    {
                        road09.Image = WindowsApplication1.Properties.Resources.road_120_aus;
                        road09.Enabled = true;
                    }
                    if (road == 9)
                    {
                        road10.Image = WindowsApplication1.Properties.Resources.road_30_aus;
                        road10.Enabled = true;
                    }
                }
                    if ((brick > 0) & (wood > 0))
                {
                    if ((stastr1 == false) & (road>0))
                    {
                        stastr01.Image = WindowsApplication1.Properties.Resources.road_90_aus;
                        stastr01.Enabled = true;
                    }
                    if ((stastr2 == false) & (road>2))
                    {
                        stastr02.Image = WindowsApplication1.Properties.Resources.road_90_aus;
                        stastr02.Enabled = true;
                    }
                    if (road>5)
                    {
                        stastr03.Image = WindowsApplication1.Properties.Resources.road_90_aus;
                        stastr03.Enabled = true;
                    }
                    if (stastr == 1)
                    {
                        stastr04.Image = WindowsApplication1.Properties.Resources.road_30_aus;
                        stastr04.Enabled = true;
                    }
                    if (stastr == 2)
                    {
                        stastr05.Image = WindowsApplication1.Properties.Resources.road_120_aus;
                        stastr05.Enabled = true;
                    }
                    if (stastr == 3)
                    {
                        stastr06.Image = WindowsApplication1.Properties.Resources.road_30_aus;
                        stastr06.Enabled = true;
                    }
                }
                //if ((brick > 0) & (wood > 0))
                //{
                //    road01.Visible = true;
                //    road01.Enabled = true;
                //}
            }
        }

        // Rohstoffreduzierung beim Bau
        
        public void baucity() //build city
        {
            for (int i = 1; i <= 3; )
            {
                if (dice10 == 5)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 5)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 5)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 5)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 5)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 5)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 2; )
            {
                if (dice10 == 4)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 4)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 4)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 4)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 4)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 4)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            draw();
            ausschalten();
            build();
        }

        public void bausettlement()
        {
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 1)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 1)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 1)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 1)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 1)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 1)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 2)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 2)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 2)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 2)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 2)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 2)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 3)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 3)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 3)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 3)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 3)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 3)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 4)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 4)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 4)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 4)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 4)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 4)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            draw();
            ausschalten();
            build();
        }

        public void bauknight()
        {
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 3)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 3)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 3)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 3)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 3)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 3)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 4)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 4)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 4)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 4)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 4)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 4)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 5)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 5)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 5)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 5)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 5)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 5)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
                draw();
                ausschalten();
                build();
            }
        }

        public void bauroad()
        {
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 1)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 1)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 1)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 1)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 1)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 1)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
            for (int i = 1; i <= 1; )
            {
                if (dice10 == 2)
                {
                    dice10 = 0;
                    i++;
                }
                else
                    if (dice20 == 2)
                    {
                        dice20 = 0;
                        i++;
                    }
                    else
                        if (dice30 == 2)
                        {
                            dice30 = 0;
                            i++;
                        }
                        else
                            if (dice40 == 2)
                            {
                                dice40 = 0;
                                i++;
                            }
                            else
                                if (dice50 == 2)
                                {
                                    dice50 = 0;
                                    i++;
                                }
                                else
                                    if (dice60 == 2)
                                    {
                                        dice60 = 0;
                                        i++;
                                    }
            }
                draw();
                ausschalten();
                build();
            }

        // Elemente build
        
        private void city01_Click(object sender, EventArgs e)
        {
            city01.Image = WindowsApplication1.Properties.Resources.city_01_an;
            city = 1;
            baucity();
            build();
        }

        private void city02_Click(object sender, EventArgs e)
        {
            city02.Image = WindowsApplication1.Properties.Resources.city_02_an;
            city = 2; 
            baucity();
            build();
        }

        private void city03_Click(object sender, EventArgs e)
        {
            city03.Image = WindowsApplication1.Properties.Resources.city_03_an;
            city = 3;
            baucity();
            build();
        }

        private void city04_Click(object sender, EventArgs e)
        {
            city04.Image = WindowsApplication1.Properties.Resources.city_04_an;
            city = 4;
            baucity();
            build();
        }

        private void settlement01_Click(object sender, EventArgs e)
        {
            settlement01.Image = WindowsApplication1.Properties.Resources.haus_01_an;
            settlement = 1;
            bausettlement();
            build();
        }

        private void settlement02_Click(object sender, EventArgs e)
        {
            settlement02.Image = WindowsApplication1.Properties.Resources.haus_02_an;
            settlement = 2;
            bausettlement();
            build();
        }

        private void settlement03_Click(object sender, EventArgs e)
        {
            settlement03.Image = WindowsApplication1.Properties.Resources.haus_03_an;
            settlement = 3;
            bausettlement();
            build();
        }

        private void settlement04_Click(object sender, EventArgs e)
        {
            settlement04.Image = WindowsApplication1.Properties.Resources.haus_04_an;
            settlement = 4;
            bausettlement();
            build();
        }

        private void settlement05_Click(object sender, EventArgs e)
        {
            settlement05.Image = WindowsApplication1.Properties.Resources.haus_05_an;
            settlement = 5;
            bausettlement();
            build();
        }

        private void settlement06_Click(object sender, EventArgs e)
        {
            settlement06.Image = WindowsApplication1.Properties.Resources.haus_06_an;
            settlement = 6;
            bausettlement();
            build();
        }

        private void knight01_Click(object sender, EventArgs e)
        {
            if (knight01an == false)
            {
                knight01.Image = WindowsApplication1.Properties.Resources.knight_01_an;
                knight = 1;
                knight01an = true;
                bauknight();
                build();
            }
            else
            {
                knight01ben = true;
                knight02ben = false;
                knight03ben = false;
                knight04ben = false;
                knight05ben = false;
                knight06ben = false;
                knightdraw(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }
        }

        private void knight02_Click(object sender, EventArgs e)
        {
            if (knight02an == false)
            {
                knight02.Image = WindowsApplication1.Properties.Resources.knight_02_an;
                knight = 2;
                knight02an = true;
                bauknight();
                build();
            }
            else
            {
                knight01ben = false;
                knight02ben = true;
                knight03ben = false;
                knight04ben = false;
                knight05ben = false;
                knight06ben = false;
                knightdraw(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void knight03_Click(object sender, EventArgs e)
        {
            if (knight03an == false)
            {
                knight03.Image = WindowsApplication1.Properties.Resources.knight_03_an;
                knight = 3;
                knight03an = true;
                bauknight();
                build();
            }
            else
            {
                knight01ben = false;
                knight02ben = false;
                knight03ben = true;
                knight04ben = false;
                knight05ben = false;
                knight06ben = false;
                knightdraw(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void knight04_Click(object sender, EventArgs e)
        {
            if (knight04an == false)
            {
                knight04.Image = WindowsApplication1.Properties.Resources.knight_04_an;
                knight = 4;
                knight04an = true;
                bauknight();
                build();
            }
            else
            {
                knight01ben = false;
                knight02ben = false;
                knight03ben = false;
                knight04ben = true;
                knight05ben = false;
                knight06ben = false;
                knightdraw(); 
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void knight05_Click(object sender, EventArgs e)
        {
            if (knight05an == false)
            {
                knight05.Image = WindowsApplication1.Properties.Resources.knight_05_an;
                knight = 5;
                knight05an = true;
                bauknight();
                build();
            }
            else
            {
                knight01ben = false;
                knight02ben = false;
                knight03ben = false;
                knight04ben = false;
                knight05ben = true;
                knight06ben = false;
                knightdraw();
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
            }

        }

        private void knight06_Click(object sender, EventArgs e)
        {
            knight06.Image = WindowsApplication1.Properties.Resources.knight_06_an;
            knight = 6;
            knight06an = true;
            bauknight();
            build();
        }

        private void road01_Click(object sender, EventArgs e)
        {
            road01.Image = WindowsApplication1.Properties.Resources.road_30_an;
            road = 1;
            bauroad();
            build();
        }

        private void road02_Click(object sender, EventArgs e)
        {
            road02.Image = WindowsApplication1.Properties.Resources.road_120_an;
            road = 2;
            bauroad();
            build();
        }

        private void road03_Click(object sender, EventArgs e)
        {
            road03.Image = WindowsApplication1.Properties.Resources.road_30_an;
            road = 3;
            bauroad();
            build();
        }

        private void road04_Click(object sender, EventArgs e)
        {
            road04.Image = WindowsApplication1.Properties.Resources.road_120_an;
            road = 4;
            bauroad();
            build();
        }

        private void road05_Click(object sender, EventArgs e)
        {
            road05.Image = WindowsApplication1.Properties.Resources.road_90_an;
            road = 5;
            bauroad();
            build();
        }

        private void road06_Click(object sender, EventArgs e)
        {
            road06.Image = WindowsApplication1.Properties.Resources.road_30_an;
            road = 6;
            bauroad();
            build();
        }

        private void road07_Click(object sender, EventArgs e)
        {
            road07.Image = WindowsApplication1.Properties.Resources.road_120_an;
            road = 7;
            bauroad();
            build();
        }

        private void road08_Click(object sender, EventArgs e)
        {
            road08.Image = WindowsApplication1.Properties.Resources.road_30_an;
            road = 8;
            bauroad();
            build();
        }

        private void road09_Click(object sender, EventArgs e)
        {
            road09.Image = WindowsApplication1.Properties.Resources.road_120_an;
            road = 9;
            bauroad();
            build();
        }

        private void road10_Click(object sender, EventArgs e)
        {
            road10.Image = WindowsApplication1.Properties.Resources.road_30_an;
            road = 10;
            bauroad();
            build();
        }

        private void stastr01_Click(object sender, EventArgs e)
        {
            stastr01.Image = WindowsApplication1.Properties.Resources.road_90_an;
            stastr1 = true;
            bauroad();
            build();        
        }

        private void stastr02_Click(object sender, EventArgs e)
        {
            stastr02.Image = WindowsApplication1.Properties.Resources.road_90_an;
            stastr2 = true;
            bauroad();
            build();         
        }

        private void stastr03_Click(object sender, EventArgs e)
        {
            stastr03.Image = WindowsApplication1.Properties.Resources.road_90_an;
            stastr = 1;
            bauroad();
            build();        
        }

        private void stastr04_Click(object sender, EventArgs e)
        {
            stastr04.Image = WindowsApplication1.Properties.Resources.road_30_an;
            stastr = 2;
            bauroad();
            build();         
        }

        private void stastr05_Click(object sender, EventArgs e)
        {
            stastr05.Image = WindowsApplication1.Properties.Resources.road_120_an;
            stastr = 3;
            bauroad();
            build();         
        }

        private void stastr06_Click(object sender, EventArgs e)
        {
            stastr06.Image = WindowsApplication1.Properties.Resources.road_90_an;
            stastr = 4;
            bauroad();
            build();         
        }

        //Runde beenden Knopf, noch bearbeiten

        private void button2_Click_1(object sender, EventArgs e)
        {
            dice1 = 0;
            dice2 = 0;
            dice3 = 0;
            dice4 = 0;
            dice5 = 0;
            dice6 = 0;
            dice10 = 0;
            dice20 = 0;
            dice30 = 0;
            dice40 = 0;
            dice50 = 0;
            dice60 = 0;
            draw();
            dice1 = 1;
            dice2 = 1;
            dice3 = 1;
            dice4 = 1;
            dice5 = 1;
            dice6 = 1;
            ausschalten();
            button1.Enabled = true;
            dicee = 3;
            label2.Text = dicee.ToString();
        }






        //Runde beenden Knopf, noch bearbeiten
        


    }
}
