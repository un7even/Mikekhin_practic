using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 300, 200);
        Rectangle Circle = new Rectangle(20, 10, 250, 250);
        Point[] Triangle = { new Point(10, 30), new Point(270, 30), new Point(270, 30), new Point(260,240), new Point(260,240), new Point(10,30)};
        Rectangle Ellipse = new Rectangle(20, 10, 350, 250);
        Rectangle Square = new Rectangle(10, 10, 200, 200);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(Color.White);
            SolidBrush Brush2 = new SolidBrush(Color.Blue);
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
                Brush2 = new SolidBrush(colorDialog1.Color);
            if (listBox1.SelectedIndex == 0)
                g.FillRectangle(Brush2, Square);
            else if (listBox1.SelectedIndex == 1)
                g.FillEllipse(Brush2, Circle);
            else if (listBox1.SelectedIndex == 2)
                g.FillRectangle(Brush2, Rectangle);
            else if (listBox1.SelectedIndex == 3)
                g.FillEllipse(Brush2, Ellipse);
            else if (listBox1.SelectedIndex == 4)
                g.FillPolygon(Brush2, Triangle);
            if (listBox1.SelectedIndex == 0)
                listBox2.Enabled = true;
            else 
                listBox2.Enabled = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle); 
            SolidBrush Brush1 = new SolidBrush(Color.Blue);
            Brush1 = new SolidBrush(colorDialog1.Color);
            if (colorDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            Pen myPen = new Pen(colorDialog2.Color, 5);
            if (listBox1.SelectedIndex == 0)
                g.DrawRectangle(myPen, Square);
            else if (listBox1.SelectedIndex == 1)
                g.DrawEllipse(myPen, Circle);
            else if (listBox1.SelectedIndex == 2)
                g.DrawRectangle(myPen, Rectangle);
            else if (listBox1.SelectedIndex == 3)
                g.DrawEllipse(myPen, Ellipse);
            else if (listBox1.SelectedIndex == 4)
                g.DrawPolygon(myPen, Triangle);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HatchBrush hBrush = new HatchBrush(HatchStyle.DarkVertical, Color.Blue, colorDialog1.Color);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            if (listBox2.SelectedIndex == 0)
                hBrush = new HatchBrush(HatchStyle.Horizontal, Color.White, colorDialog1.Color);
            else if (listBox2.SelectedIndex == 1)
                hBrush = new HatchBrush(HatchStyle.Vertical, Color.White, colorDialog1.Color);
            else if (listBox2.SelectedIndex == 2)
                hBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.White, colorDialog1.Color);
            else if (listBox2.SelectedIndex == 3)
                hBrush = new HatchBrush(HatchStyle.ForwardDiagonal, Color.White, colorDialog1.Color);
            else if (listBox2.SelectedIndex == 4)
                hBrush = new HatchBrush(HatchStyle.Cross, Color.White, colorDialog1.Color);
            else if (listBox2.SelectedIndex == 5)
                hBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.White, colorDialog1.Color);
            else if (listBox2.SelectedIndex == 6)
                hBrush = new HatchBrush(HatchStyle.DiagonalBrick, Color.White, colorDialog1.Color);
                g.FillRectangle(hBrush, Square);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
