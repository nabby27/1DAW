using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ivan_CordobaEj3
{
    public partial class Ejercicio3 : Form
    {
        int currentImage;
        public Ejercicio3()
        {
            InitializeComponent();
            currentImage = -1;
        }

        private void btToRight_Click(object sender, EventArgs e)
        {
            timerToRight.Start();
            btToLeft.Enabled = false;
        }

        private void timerToRight_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Visible)
            {
                pictureBox4.Visible = true;
                timerToRight.Stop();
            }
            else if (pictureBox2.Visible)
            {
                pictureBox3.Visible = true;
            }
            else if (pictureBox1.Visible)
            {
                pictureBox2.Visible = true;
            }
            pictureBox1.Visible = true;
        }

        private void btToLeft_Click(object sender, EventArgs e)
        {
            timerToLeft.Start();
            btToRight.Enabled = false;
        }

        private void timerToLeft_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible)
            {
                pictureBox1.Visible = true;
                timerToLeft.Stop();
            }
            else if (pictureBox3.Visible)
            {
                pictureBox2.Visible = true;
            }
            else if (pictureBox4.Visible)
            {
                pictureBox3.Visible = true;
            }
            pictureBox4.Visible = true;
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false; 
            pictureBox4.Visible = false;
            timerToLeft.Stop();
            timerToRight.Stop();
            btToRight.Enabled = true;
            btToLeft.Enabled = true;
        }
    }
}
