using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Color_Block_Game
{
    public partial class Form1 : Form
    {
        private int score;
        private int speed;
        private int lifes;
        private int delayPanelGenerate;
        private int delay;
        private Random randomGenerate = new Random();


        public Form1()
        {
            InitializeComponent();
            gameReset();
        }



        private Color getRandomColor()
        {
            int k = randomGenerate.Next(1, 4);
            if (k == 1)
            {
                return Color.Red;
            }
            else if (k == 2)
            {
                return Color.Blue;
            }
            else
            {
                return Color.Green;
            }
        }

        private void generateRandomPanel()
        {
            Panel p = new Panel();
            p.Size = new Size(407, 25);
            p.Location = new Point(0, 0);
            p.Tag = "Color";
            p.BackColor = getRandomColor();
            p.Visible = true;
            p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pnlRunningBlock.Controls.Add(p);
        }

        private void gameReset()
        {
            button1.Visible = false;
            score = 0;
            lifes = 3;
            delayPanelGenerate = 57;
            delay = delayPanelGenerate;
            speed = 6;
            pnlGame.BackColor = getRandomColor();
            foreach (Control x in pnlRunningBlock.Controls)
            {
                if ((string)x.Tag == "Color")
                {
                   pnlRunningBlock.Controls.Remove(x);
                }
            }
            lblLifes.Text = "Lifes: 3";
            lblScore.Text = "Score: 0";
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (delay == delayPanelGenerate)
            {
                generateRandomPanel();
                delay = 0;
            }
            foreach (Control x in pnlRunningBlock.Controls)
            {
                if ((string)x.Tag == "Color")
                {
                    int newY = x.Location.Y + speed;
                    x.Location = new Point(x.Location.X, newY);

                    if (x.Location.Y == 582 || x.Location.Y > pnlGame.Location.Y + 80)
                    {
                        pnlRunningBlock.Controls.Remove(x);
                    }
                }
            }
            delay++;

            if (lifes == 0)
            {
                button1.Visible = true;
                gameTimer.Stop();
            }    
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                foreach (Control x in pnlRunningBlock.Controls)
                {
                    if ((string)x.Tag == "Color")
                    {
                        if (((x.Location.Y >= pnlGame.Location.Y - pnlGame.Height - speed && x.Location.Y <= pnlGame.Location.Y + (speed + pnlGame.Height)) && (x.BackColor == pnlGame.BackColor)))
                        {
                            score++;
                            lblScore.Text = "Score: " + score;
                            pnlGame.BackColor = getRandomColor();
                            pnlRunningBlock.Controls.Remove(x);
                        }
                        else if (((x.Location.Y >= pnlGame.Location.Y - pnlGame.Height - speed && x.Location.Y <= pnlGame.Location.Y + (speed + pnlGame.Height)) && (x.BackColor != pnlGame.BackColor)))
                        {
                            lifes--;
                            lblLifes.Text = "Lifes: " + lifes;
                            pnlRunningBlock.Controls.Remove(x);
                        }
                    }
                }
                
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Space && isPress == true)
            //{
            //    isPress = false;
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Space && isPress == false)
            //{
            //    isPress = true;
            //    foreach (Control x in pnlRunningBlock.Controls)
            //    {
            //        if ((string)x.Tag == "Color")
            //        {
            //            if (((x.Location.Y <= pnlGame.Location.Y + 30 + speed && x.Location.Y >= pnlGame.Location.Y + (speed + 2)) && (x.BackColor == pnlGame.BackColor)))
            //            {
            //                score++;
            //                lblScore.Text = "Score: " + score;
            //                pnlGame.BackColor = getRandomColor();
            //                pnlRunningBlock.Controls.Remove(x);
            //            }
            //        }
            //    }
            //}
        }

        //private void btnRestart_Click(object sender, EventArgs e)
        //{
            
        //    gameReset();
        //}

        private void btnRestart_Click(object sender, EventArgs e)
        {
            gameReset();
            score = 0;
            this.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
