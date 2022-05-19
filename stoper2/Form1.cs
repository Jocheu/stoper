using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoper2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        int s = 0;
        int s2 = 0;
        int m1 = 0;
        int m2 = 0;
        int h = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 10)
            {
                s = 0;
                s2 += 1;
            }
            if (s2 == 6)
            {
                s2 = 0;
                m1 += 1;
            }
            if (m1 == 10)
            {
                m1 = 0;
                m2 += 1;
            }
            if (m2 == 6)
            {
                m2 = 0;
                h += 1;
            }
            pictureBox1.Image = imageList1.Images[h];
            pictureBox1.Refresh();
            pictureBox2.Image = imageList1.Images[m2];
            pictureBox2.Refresh();
            pictureBox3.Image = imageList1.Images[m1];
            pictureBox3.Refresh();
            pictureBox4.Image = imageList1.Images[s];
            pictureBox4.Refresh();
            pictureBox5.Image = imageList1.Images[s2];
            pictureBox5.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (i == 0)
            {
                timer1.Enabled = true;
                button1.Text = "stop";
                i = 1;
            }
            else if (i == 1)
            {
                timer1.Enabled = false;
                button1.Text = "reset";
                label8.Text = h.ToString() + " : " + m2.ToString() + m1.ToString() + " : " + s2.ToString() + s.ToString();
                i = 2;
            }
            else if (i == 2)
            {
                button1.Text = "start";
                i = 0;
                pictureBox1.Image = imageList1.Images[0];
                pictureBox1.Refresh();
                pictureBox2.Image = imageList1.Images[0];
                pictureBox2.Refresh();
                pictureBox3.Image = imageList1.Images[0];
                pictureBox3.Refresh();
                pictureBox4.Image = imageList1.Images[0];
                pictureBox4.Refresh();
                pictureBox5.Image = imageList1.Images[0];
                pictureBox5.Refresh();
                s = 0;
                s2 = 0;
                m1 = 0;
                m2 = 0;
                h = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
