using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ej0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label.Font = new Font("Microsoft Sans Serif", 8.25f,  FontStyle.Italic);
            label.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label.Font = new Font("Arial", 20, FontStyle.Bold);
            label.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label.Font = new Font("Arial", 15, FontStyle.Strikeout);
            label.ForeColor = Color.Red;
        }
    }
}
