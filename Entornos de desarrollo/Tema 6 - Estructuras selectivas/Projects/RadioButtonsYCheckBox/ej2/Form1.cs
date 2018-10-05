using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectCheckBox(object sender, EventArgs e)
        {
            label.Visible = true;
            label.Text = "";
            if (checkBox1.Checked)
            {
                label.Text += " Opción 1 ";
            }
            if (checkBox2.Checked)
            {
                label.Text += " Opción 2 ";
            }
            if (checkBox3.Checked)
            {
                label.Text += " Opción 3 ";
            }
        }
    }
}
