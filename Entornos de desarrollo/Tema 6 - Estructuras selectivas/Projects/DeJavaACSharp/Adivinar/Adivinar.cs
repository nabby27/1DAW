using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adivinar
{
    public partial class Adivinar : Form
    {
        public Adivinar()
        {
            InitializeComponent();
        }

        int cont = 0;

        public void ocultarNumero(object sender, EventArgs e)
        {
            if (tbNumero.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                tbNumero.Hide();
        }

        public void adivinar(object sender, EventArgs e)
        {
            if (tbAdivina.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbNumero.Text.Equals(""))
                MessageBox.Show("Introduce un número a adivinar antes", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int numAdivinar = Int32.Parse(tbNumero.Text);
                int num = Int32.Parse(tbAdivina.Text);
                cont++;
                if (num > numAdivinar)
                {
                    MessageBox.Show("Te has pasado", "Casi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (num < numAdivinar)
                {
                    MessageBox.Show("Te has quedado corto", "Casi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Correcto!", "Acierto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lIntentos.Visible = true;
                    tbNumero.Show();
                    tbNumero.Enabled = false;
                    lIntentos.Text = "Has acertado al intento número: " + cont;
                }
            }
        }

        public void reset(object sender, EventArgs e)
        {
            lIntentos.Visible = false;
            lIntentos.Text = "";
            tbNumero.Clear();
            tbNumero.Enabled = true;
            tbAdivina.Clear();
            tbNumero.Show();
            cont = 0;
        }

    }
}
