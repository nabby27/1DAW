using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void btBlue_Click(object sender, EventArgs e)
        {
            lMouseText.ForeColor = Color.Blue;
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            lMouseText.ForeColor = Color.Red;
        }

        private void Form1_Click(object sender, MouseEventArgs e)
        {
            lMouseText.Text = "Se ha pulsado el botón " + e.Button + " en la posición [" + e.X + ", " + e.Y + "]";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lKeyText.Text = "[ " + e.KeyChar.ToString() + " ]";
        }

    }
}
