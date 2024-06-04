using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp51
{
    public partial class Form1 : Form
    {
        private Point point;
        bool move,move2,moove3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString() + "," + e.Y.ToString();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = e.X.ToString() + "," + e.Y.ToString();
            if (move)
            {
                button1.Left = e.X + button1.Left - point.X;
                button1.Top = e.Y + button1.Top - point.Y;
            }
        }   

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
           // button1.Left = e.X+button1.Left-point.X;
           // button1.Top = e.X + button1.Top - point.X;
            move = false;

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            move2 = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move2)
            {
                pictureBox1.Left = e.X + pictureBox1.Left - point.X;
                pictureBox1.Top = e.Y + pictureBox1.Top - point.Y;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            moove3 = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (moove3)
            {
                pictureBox2.Left = e.X + pictureBox2.Left - point.X;
                pictureBox2.Top = e.Y + pictureBox2.Top - point.Y;

            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            moove3 = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            move2 = true;
        }
    }
}
