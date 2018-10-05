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

        private void rbEdad_CheckedChanged(object sender, EventArgs e)
        {
            lEdad.Visible = true;
            if (rbMenor40.Checked)
                lEdad.Text = "Tienes menos de 40 años";
            else if (rb40_60.Checked)
                lEdad.Text = "Tienes entre 40 y 60 años";
            else if (rbMayor60.Checked)
                lEdad.Text = "Tienes más de 60 años";
        }

        private void rbSexo_CheckedChanged(object sender, EventArgs e)
        {
            lSexo.Visible = true;
            if (rbHombre.Checked)
                lSexo.Text = "Eres hombre";
            else if (rbMujer.Checked)
                lSexo.Text = "Eres mujer";
        }

    }
}
