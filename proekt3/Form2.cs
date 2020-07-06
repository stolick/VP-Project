using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proekt3
{
    public partial class Form2 : Form
    {
        bool left;
        bool right;
        bool fleg1 = true, fleg2 = true, fleg3 = true;
        int speed = 7;
        int count = 0;
        public int score = 0;
        public static int highest = 0;
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            endText1.Text = "Game Over!";
            endText2.Text = "Your final score is " + score;
            endText1.Visible = false;
            endText2.Visible = false;
            button1.Visible = false;
            btnQuit2.Visible = false;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.DialogResult = DialogResult.OK;
            form2.ShowDialog();
       //     this.Close();
        }

        private void flamingo_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit2_Click(object sender, EventArgs e)
        {
            this.Close();
     //       this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (right == true)
            {
                if (flamingo.Left + 9 >= panel1.Size.Width - flamingo.Size.Width)
                {
                    flamingo.Left = panel1.Width - flamingo.Size.Width;
                    right = false;
                }
                else
                {
                    flamingo.Left += 9;
                }
            }
            else


                if (left == true)
                {
                    if (flamingo.Left - 9 <= panel1.Left)
                    {
                        flamingo.Left = panel1.Left;
                        left = false;

                    }
                    else
                    {
                        flamingo.Left -= 9;
                    }
                }


            Random r = new Random();

            count++;
            score++;
            if (count == 500)
                speed += 3;
            if (count == 1000)
                speed += 3;
            if (count == 1500)
                speed += 3;

            //first cloud
            if (cloud1.Top - speed <= panel1.Size.Height / 2)
            {


                if (fleg1 == true)
                {
                    cloud4.Visible = true;
                    fleg1 = false;
                    //  cloud4.Visible = true;
                    cloud4.Top = panel1.Bottom + cloud5.Height;
                    cloud4.Left = r.Next(0, panel1.Size.Width/3 - cloud1.Size.Width);
                    cloud1.Top -= speed;
                    cloud4.Top -= speed;
                }
                else
                {
                    cloud1.Top -= speed;
                }
            }
            else
            {
                cloud1.Top -= speed;
            }

            //second cloud
            if (cloud2.Top - speed <= panel1.Size.Height / 2)
            {
                if (fleg2 == true)
                {
                    cloud5.Visible = true;
                    fleg2 = false;
                    cloud5.Top = panel1.Bottom + cloud2.Height;
                    cloud5.Left = r.Next(panel1.Size.Width / 3, panel1.Size.Width / 3 + panel1.Size.Width / 3 - cloud1.Size.Width);
                    cloud2.Top -= speed;
                    cloud5.Top -= speed;
                }
                else
                {
                    cloud2.Top -= speed;
                }
            }
            else
            {
                cloud2.Top -= speed;
            }

            //third cloud
            if (cloud3.Top - speed <= panel1.Size.Height / 2)
            {
                if (fleg3 == true)
                {
                    cloud6.Visible = true;
                    fleg3 = false;
                    cloud6.Top = panel1.Bottom + cloud3.Height;
                    cloud6.Left = r.Next(panel1.Size.Width / 3 + panel1.Size.Width / 3, panel1.Size.Width - cloud1.Size.Width);
                    cloud3.Top -= speed;
                    cloud6.Top -= speed;
                }
                else
                {
                    cloud3.Top -= speed;
                }
            }
            else
            {
                cloud3.Top -= speed;

            }

            //fourth cloud
            if (cloud4.Top - speed <= panel1.Size.Height / 2)
            {
                if (fleg1 == false)
                {
                    fleg1 = true;
                    //cloud.Visible = true;
                    cloud1.Top = panel1.Bottom + cloud1.Height;
                    cloud1.Left = r.Next(0, panel1.Size.Width / 3 - cloud1.Size.Width);
                    cloud1.Top -= speed;
                    cloud4.Top -= speed;
                }
                else
                {
                    cloud4.Top -= speed;
                }
            }
            else
            {
                cloud4.Top -= speed;
            }

            //fifth cloud

            if (cloud5.Top - speed <= panel1.Size.Height / 2)
            {
                if (fleg2 == false)
                {
                    fleg2 = true;
                    //cloud.Visible = true;
                    cloud2.Top = panel1.Bottom + cloud1.Height;
                    cloud2.Left = r.Next(panel1.Size.Width / 3, panel1.Size.Width / 3 + panel1.Size.Width / 3 - cloud1.Size.Width);
                    cloud2.Top -= speed;
                    cloud5.Top -= speed;
                }
                else
                {
                    cloud5.Top -= speed;
                }
            }
            else
            {
                cloud5.Top -= speed;
            }

            //sixst cloud


            if (cloud6.Top - speed <= panel1.Size.Height / 2)
            {
                if (fleg3 == false)
                {
                    fleg3 = true;
                    //cloud.Visible = true;
                    cloud3.Top = panel1.Bottom + cloud1.Height;
                    cloud3.Left =r.Next(panel1.Size.Width / 3 + panel1.Size.Width / 3, panel1.Size.Width - cloud1.Size.Width);
                    cloud3.Top -= speed;
                    cloud6.Top -= speed;
                }
                else
                {
                    cloud6.Top -= speed;
                }
            }
            else
            {
                cloud6.Top -= speed;
            }
            if (flamingo.Bounds.IntersectsWith(cloud1.Bounds))
            {
                endGame();
            }
            else if (flamingo.Bounds.IntersectsWith(cloud2.Bounds))
            {
                endGame();
            }
            else if (flamingo.Bounds.IntersectsWith(cloud3.Bounds))
            {
                endGame();
            }
            else if (flamingo.Bounds.IntersectsWith(cloud4.Bounds))
            {
                endGame();
            }
            else if (flamingo.Bounds.IntersectsWith(cloud5.Bounds))
            {
                endGame();
            }
            else if (flamingo.Bounds.IntersectsWith(cloud6.Bounds))
            {
                endGame();
            }

            Invalidate();
        }

        private void cloud5_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            timer1.Stop();
            highestScore(score);
            endText2.Text = "Your final score is " + score;
            endText1.Visible = true;
            endText2.Visible = true;
            button1.Visible = true;
            btnQuit2.Visible = true;
        }



        public static void highestScore(int score)
        {
            if (score > Form2.highest)
                Form2.highest = score;
        }







    }
}