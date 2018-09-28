using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bNegrita_Click(object sender, EventArgs e)
        {
            label.Font = new Font(label.Font, FontStyle.Bold);
        }

        private void bCursiva_Click(object sender, EventArgs e)
        {
            label.Font = new Font(label.Font, FontStyle.Italic);
        }

        private void bTachado_Click(object sender, EventArgs e)
        {
            label.Font = new Font(label.Font, FontStyle.Strikeout);
        }

        private void bSubrayado_Click(object sender, EventArgs e)
        {
            label.Font = new Font(label.Font, FontStyle.Underline);
        }

    }
}
