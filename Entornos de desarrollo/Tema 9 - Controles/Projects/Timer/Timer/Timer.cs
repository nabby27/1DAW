using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Cerrando sesión";
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = "Cerrando la aplicación";
            timer2.Stop();
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer3.Stop();
            this.Close();
        }
    }
}
