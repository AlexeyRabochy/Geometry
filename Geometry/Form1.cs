using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw(MyRectangle a, Color color)
        {

            SolidBrush myBrush = new System.Drawing.SolidBrush(color);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            formGraphics.FillRectangle(myBrush, (float)a.A.X * 3, (float)a.A.Y * 3, (float)Math.Abs(a.A.X - a.B.X) * 3, (float)Math.Abs(a.A.Y - a.B.Y) * 3);
            myBrush.Dispose();
            formGraphics.Dispose();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            Action(sender, e);
        }

        private void Action(object sender, EventArgs e)
        {
            MyRectangle a = new MyRectangle(new MyPoint(double.Parse(x11box.Text), double.Parse(y11box.Text)),
                    new MyPoint(double.Parse(x12box.Text), double.Parse(y12box.Text)));
            MyRectangle b = new MyRectangle(new MyPoint(double.Parse(x21box.Text), double.Parse(y21box.Text)),
                new MyPoint(double.Parse(x22box.Text), double.Parse(y22box.Text)));
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.White);
            Draw(a, Color.PowderBlue);
            Draw(b, Color.SaddleBrown);
            bool ifIntersect = Geom.check(a, b);
            if (ifIntersect)
            {
                res.Text = "Intersect!";
                res.BackColor = Color.Green;
            }
            else
            {
                res.Text = "No intersect :(";
                res.BackColor = Color.Red;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Action(sender, e);
        }
    }
}
