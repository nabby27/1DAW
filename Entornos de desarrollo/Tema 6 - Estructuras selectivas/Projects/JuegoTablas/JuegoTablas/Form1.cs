using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JuegoTablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void play(object sender, EventArgs e)
        {
            if (tbNum.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int num = Int32.Parse(tbNum.Text);
                tbNum.Enabled = false;
                //int randomNum = Random
            }
        }

        private void change(object sender, EventArgs e)
        {

        }

        private void reset(object sender, EventArgs e)
        {

        }
    }
}
