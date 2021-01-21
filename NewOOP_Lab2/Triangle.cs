using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab2
{
    class Triangle
    {
        private int redcolor { get; set; }
        private int greencolor { get; set; }
        private int bluecolor { get; set; }
        private bool visibility;
        private int x1 { get; set; }
        private int x2 { get; set; }
        private int x3 { get; set; }
        private int y1 { get; set; }
        private int y2 { get; set; }
        private int y3 { get; set; }

        public Triangle()
        {
            Random randomint = new Random();
            int x = randomint.Next(0, 1054);
            int y = randomint.Next(0, 685);
            int r = randomint.Next(0, 150);
            this.x1 = randomint.Next(x - r, x + r);
            this.y1 = randomint.Next(y - r, y + r);
            this.x2 = randomint.Next(x - r, x + r);
            this.y2 = randomint.Next(y - r, y + r);
            this.x3 = randomint.Next(x - r, x + r);
            this.y3 = randomint.Next(y - r, y + r);
            this.visibility = true;
            this.redcolor = randomint.Next(0, 256);
            this.greencolor = randomint.Next(0, 256);
            this.bluecolor = randomint.Next(0, 256);
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
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
                    gr.FillPolygon(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), new[] { x1, y1; x2, y2; x3, y3; });
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawPolygon(new Pen(Color.White), x1, y1, x2, y2, x3, y3);
                    }
                    else
                    {
                        gr.DrawPolygon(new Pen(Color.Black), x1, y1, x2, y2, x3, y3);
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        public void MoveTo(int x, int y)
        {
            this.t1.X += x;
            this.t2.X += x;
            this.t3.X += x;
            this.t1.Y += y;
            this.t2.Y += y;
            this.t3.Y += y;
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
