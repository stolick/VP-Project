using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace proekt3
{
    class Clouds
    {


        private Bitmap cloud;
        private int brzina;
        Form2 f;
      
        bool fleg1 = true, fleg2 = true, fleg3 = true;

        public Clouds(){
            cloud = new Bitmap(Properties.Resources.cloud1);
            brzina = 0;
               f = new Form2();

        }

        public void Cloud(){

            Random r = new Random();

            //first cloud
           
            if (f.cloud1.Top - 9 <= f.panel1.Size.Height / 2)
            {
                if (fleg1 == true)
                {
                    f.cloud4.Visible = true;
                    fleg1 = false;
                    //  cloud4.Visible = true;
                   f.cloud4.Top = f.panel1.Bottom + f.cloud1.Height;
                   f.cloud4.Left = r.Next(0, f.panel1.Size.Width / 2 - f.cloud1.Size.Width);
                   f.cloud1.Top -= 9;
                   f.cloud4.Top -= 9;
                }
                else
                {
                    f.cloud1.Top -= 9;
                }
            }
            else
            {
                f.cloud1.Top -= 9;
            }

            //second cloud
            if (f.cloud2.Top - 9 <= f.panel1.Size.Height / 2)
            {
                if (fleg2 == true)
                {
                    f.cloud5.Visible = true;
                    fleg2 = false;
                    f.cloud5.Top = f.panel1.Bottom + f.cloud2.Height;
                    f.cloud5.Left = r.Next(f.panel1.Size.Width / 2, f.panel1.Size.Width - f.cloud1.Size.Width);
                    f.cloud2.Top -= 9;
                    f.cloud5.Top -= 9;
                }
                else
                {
                    f.cloud2.Top -= 9;
                }
            }
            else
            {
                f.cloud2.Top -= 9;
            }

            //third cloud
            if (f.cloud3.Top - 9 <= f.panel1.Size.Height / 2)
            {
                if (fleg3 == true)
                {
                    f.cloud6.Visible = true;
                    fleg3 = false;
                    f.cloud6.Top = f.panel1.Bottom + f.cloud3.Height;
                    f.cloud6.Left = r.Next(0, f.panel1.Size.Width / 2 - f.cloud1.Size.Width);
                    f.cloud3.Top -= 9;
                    f.cloud6.Top -= 9;
                }
                else
                {
                    f.cloud3.Top -= 9;
                }
            }
            else
            {
                f.cloud3.Top -= 9;

            }

            //fourth cloud
            if (f.cloud4.Top - 9 <= f.panel1.Size.Height / 2)
            {
                if (fleg1 == false)
                {
                    fleg1 = true;
                    //cloud.Visible = true;
                    f.cloud1.Top = f.panel1.Bottom + f.cloud1.Height;
                    f.cloud1.Left = r.Next(f.panel1.Size.Width / 2, f.panel1.Size.Width - f.cloud1.Size.Width);
                    f.cloud1.Top -= 9;
                    f.cloud4.Top -= 9;
                }
                else
                {
                    f.cloud4.Top -= 9;
                }
            }
            else
            {
                f.cloud4.Top -= 9;
            }

            //fifth cloud

            if (f.cloud5.Top - 9 <= f.panel1.Size.Height / 2)
            {
                if (fleg2 == false)
                {
                    fleg2 = true;
                    //cloud.Visible = true;
                    f.cloud2.Top = f.panel1.Bottom + f.cloud1.Height;
                    f.cloud2.Left = r.Next(0, f.panel1.Size.Width / 2 - f.cloud1.Size.Width);
                    f.cloud2.Top -= 9;
                    f.cloud5.Top -= 9;
                }
                else
                {
                    f.cloud5.Top -= 9;
                }
            }
            else
            {
                f.cloud5.Top -= 9;
            }

            //sixst cloud


            if (f.cloud6.Top - 9 <= f.panel1.Size.Height / 2)
            {
                if (fleg3 == false)
                {
                    fleg3 = true;
                    //cloud.Visible = true;
                    f.cloud3.Top = f.panel1.Bottom + f.cloud1.Height;
                    f.cloud3.Left = r.Next(f.panel1.Size.Width / 2, f.panel1.Size.Width - f.cloud1.Size.Width);
                    f.cloud3.Top -= 9;
                    f.cloud6.Top -= 9;
                }
                else
                {
                    f.cloud6.Top -= 9;
                }
            }
            else
            {
                f.cloud6.Top -= 9;
            }

        }


    }
}

    