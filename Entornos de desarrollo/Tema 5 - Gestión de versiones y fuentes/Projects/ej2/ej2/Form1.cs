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

        private void bAzul1_Click(object sender, EventArgs e)
        {
            lText.Visible = true;
            lText.ForeColor = Color.Blue;
        }

        private void bRojo_Click(object sender, EventArgs e)
        {
            lText.Visible = true;
            lText.ForeColor = Color.Red;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            lRaton.Visible = true;
            lRaton.Text = "Se ha pulsado el boton " + e.Button + " en la posición [" + e.X + ", " + e.Y + "]";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lTeclado.Visible = true;
            lTeclado.Text = "Has apretado la tecla " + e.KeyChar;
        }


    }
}
