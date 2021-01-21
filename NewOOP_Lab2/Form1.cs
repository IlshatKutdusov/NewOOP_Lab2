using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Part
        {
            public string PartName { get; set; }
            public int PartId { get; set; }
        }

        public static int redcolor = 0, greencolor = 0, bluecolor = 0;

        private int x, y, r, i = -1, k = -1, kcircle = -1, ktriangle = -1, krectangle = -1;

        private List<Part> list = new List<Part>();
        private List<Circle> circlelist = new List<Circle>();
        private List<Triangle> trianglelist = new List<Triangle>();
        private List<Rectangle> rectanglelist = new List<Rectangle>();

        private Circle circle;
        private Triangle triangle;
        private Rectangle rectangle;
        private Point t1, t2, t3;
        private Random randomint = new Random();

        private void UpDate()
        {
            pictureBox1.Image = null;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].PartName == "circle")
                {
                    circlelist[list[i].PartId].Show(pictureBox1);
                }
                else
                {
                    if (list[i].PartName == "triangle")
                    {
                        trianglelist[list[i].PartId].Show(pictureBox1);
                    }
                    else
                    {
                        if (list[i].PartName == "rectangle")
                        {
                            rectanglelist[list[i].PartId].Show(pictureBox1);
                        }
                    }
                }
            }
        }

        private void EnableFunc()
        {
            if (button6.Enabled == false)
            {
                button6.Enabled = true;
                comboBox1.Enabled = true;
                button7.Enabled = true;
                comboBox2.Enabled = true;
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }

        private void ListAddCircle()
        {
            kcircle++;
            circlelist.Add(circle);
            list.Add(new Part() { PartName = "circle", PartId = kcircle });
            i++;
            comboBox1.Items.Add(i + ". Circle(" + kcircle + ") R=" + redcolor + " G=" + greencolor + " B=" + bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Circle(" + kcircle + ")  R=" + redcolor + " G=" + greencolor + " B=" + bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void ListAddTriangle()
        {
            ktriangle++;
            trianglelist.Add(triangle);
            list.Add(new Part() { PartName = "triangle", PartId = ktriangle });
            i++;
            comboBox1.Items.Add(i + ". Triangle(" + ktriangle + ") R=" + redcolor + " G=" + greencolor + " B=" + bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Triangle(" + ktriangle + ")  R=" + redcolor + " G=" + greencolor + " B=" + bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void ListAddRectangle()
        {
            krectangle++;
            rectanglelist.Add(rectangle);
            list.Add(new Part() { PartName = "rectangle", PartId = krectangle });
            i++;
            comboBox1.Items.Add(i + ". Rectangle(" + krectangle + ") R=" + redcolor + " G=" + greencolor + " B=" + bluecolor);
            comboBox1.SelectedIndex = i;
            comboBox2.Items.Add(i + ". Rectangle(" + krectangle + ")  R=" + redcolor + " G=" + greencolor + " B=" + bluecolor);
            comboBox2.SelectedIndex = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle = new Circle(Convert.ToInt16(numericUpDown3.Value), Convert.ToInt16(numericUpDown4.Value), Convert.ToInt16(numericUpDown5.Value), true, redcolor, greencolor, bluecolor);
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1.X = Convert.ToInt16(numericUpDown6.Value);
            t1.Y = Convert.ToInt16(numericUpDown7.Value);
            t2.X = Convert.ToInt16(numericUpDown8.Value);
            t2.Y = Convert.ToInt16(numericUpDown9.Value);
            t3.X = Convert.ToInt16(numericUpDown10.Value);
            t3.Y = Convert.ToInt16(numericUpDown11.Value);

            triangle = new Triangle(t1.X, t1.Y, t2.X, t2.Y, t3.X, t3.Y, true, redcolor, greencolor, bluecolor);
            triangle.Show(pictureBox1);
            ListAddTriangle();
            EnableFunc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rectangle = new Rectangle(Convert.ToInt16(numericUpDown12.Value), Convert.ToInt16(numericUpDown13.Value), Convert.ToInt16(numericUpDown14.Value), Convert.ToInt16(numericUpDown15.Value), true, redcolor, greencolor, bluecolor);
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 colorsel = new Form2(this);
            colorsel.ShowDialog();
            button5.BackColor = Color.FromArgb(redcolor, greencolor, bluecolor);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            k = comboBox1.SelectedIndex;

            if (list[k].PartName == "circle")
            {
                circlelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
            }
            else
            {
                if (list[k].PartName == "triangle")
                {
                    trianglelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                }
                else
                {
                    if (list[k].PartName == "rectangle")
                    {
                        rectanglelist[list[k].PartId].MoveTo(Convert.ToInt16(numericUpDown1.Value), Convert.ToInt16(numericUpDown2.Value));
                    }
                }
            }
            UpDate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            k = comboBox2.SelectedIndex;

            if (list[k].PartName == "circle")
            {
                circlelist[list[k].PartId].Visibility();
            }
            else
            {
                if (list[k].PartName == "triangle")
                {
                    trianglelist[list[k].PartId].Visibility();
                }
                else
                {
                    if (list[k].PartName == "rectangle")
                    {
                        rectanglelist[list[k].PartId].Visibility();
                    }
                }
            }
            UpDate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            circle = new Circle();
            circle.Show(pictureBox1);
            ListAddCircle();
            EnableFunc();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            triangle = new Triangle();
            triangle.Show(pictureBox1);
            ListAddTriangle();
            EnableFunc();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rectangle = new Rectangle();
            rectangle.Show(pictureBox1);
            ListAddRectangle();
            EnableFunc();
        }
    }
}
