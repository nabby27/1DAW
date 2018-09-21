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

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRojo_Click(object sender, EventArgs e)
        {
            lColorTexto.ForeColor = Color.Red;
        }

        private void bVerde_Click(object sender, EventArgs e)
        {
            lColorTexto.ForeColor = Color.Green;
        }

        private void bIzquierda_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Left - 10, Top);
        }

        private void bDerecha_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Left + 10, Top);
        }

        private void bCentro_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //Screen resPantalla = Screen.PrimaryScreen;
            //int altoPantalla = resPantalla.Bounds.Height;
            //int anchoPantalla = resPantalla.Bounds.Width;
            //int altoFormulario = this.ClientSize.Height;
            //int anchoFormulario = this.ClientSize.Width;
            //int posX = (anchoPantalla - anchoFormulario) / 2;
            //int posY = (altoPantalla - altoFormulario) / 2;
            //this.Location = new Point(posX, posY);          
        }

    }
}
