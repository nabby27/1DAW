using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doble
{
    public partial class Doble : Form
    {
        public Doble()
        {
            InitializeComponent();
        }

        private void calcularDoble(object sender, EventArgs e)
        {
            if (tbValor.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Int32.Parse(tbValor.Text) == 0)
                this.Close();
            else
            {
                int num = Int32.Parse(tbValor.Text);
                this.Size = new Size(271, 186);
                lValorDoble.Visible = true;
                tbValorDoble.Visible = true;
                bReiniciar.Visible = true;
                tbValorDoble.Text = (num * 2).ToString();
                tbValorDoble.Enabled = false;
            }
        }

        private void reiniciar(object sender, EventArgs e)
        {
            this.Size = new Size(271, 110);
            lValorDoble.Visible = false;
            tbValorDoble.Visible = false;
            bReiniciar.Visible = false;
            tbValorDoble.Text = "";
            tbValor.Text = "";
        }

    }
}
