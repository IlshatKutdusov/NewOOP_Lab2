﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab2
{
    class Circle
    {
        private int x { get; set; }
        private int y { get; set; }
        private int r { get; set; }
        private int redcolor { get; set; }
        private int greencolor { get; set; }
        private int bluecolor { get; set; }
        private bool visibility;

        public Circle()
        {
            Random randomint = new Random();
            this.x = randomint.Next(0, 1054);
            this.y = randomint.Next(0, 685);
            this.r = randomint.Next(0, 150);
            this.visibility = true;
            this.redcolor = randomint.Next(0, 256);
            this.greencolor = randomint.Next(0, 256);
            this.bluecolor = randomint.Next(0, 256);
        }

        public Circle(int x, int y, int r, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            this.visibility = visibility;
            this.redcolor = redcolor;
            this.greencolor = greencolor;
            this.bluecolor = bluecolor;
        }

        public void Show(PictureBox pictureBox1)
        {
            if (visibility == true)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap newbmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics gr = Graphics.FromImage(newbmp))
                    {
                        gr.Clear(Color.White);
                    }
                    pictureBox1.Image = newbmp;
                }
                using (Graphics gr = Graphics.FromImage(pictureBox1.Image))
                {
                    gr.FillEllipse(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), x - r, y - r, 2 * r, 2 * r);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawEllipse(new Pen(Color.White), x - r, y - r, 2 * r, 2 * r);
                    }
                    else
                    {
                        gr.DrawEllipse(new Pen(Color.Black), x - r, y - r, 2 * r, 2 * r);
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        public void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public void Visibility()
        {
            if (this.visibility == false)
            {
                this.visibility = true;
            }
            else
            {
                this.visibility = false;
            }
        }
    }
}
