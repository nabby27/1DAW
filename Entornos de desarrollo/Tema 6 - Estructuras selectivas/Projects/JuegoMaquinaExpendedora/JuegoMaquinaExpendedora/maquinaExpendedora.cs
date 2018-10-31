using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JuegoMaquinaExpendedora
{
    public partial class maquinaExpendedora : Form
    {
        public maquinaExpendedora()
        {
            InitializeComponent();
        }

        int precioAgua;
        int precioCafe;
        int precioRefresco;
        int dineroAPagar;
        int dineroIntroducido;

        private void pagar(object sender, EventArgs e)
        {
            if (rbAgua.Checked || rbCafe.Checked || rbRefresco.Checked)
            {
                rbAgua.Enabled = false;
                rbCafe.Enabled = false;
                rbRefresco.Enabled = false;
                if (rbAgua.Checked)
                    dineroAPagar = precioAgua;
                if (rbCafe.Checked)
                    dineroAPagar = precioCafe;
                if (rbRefresco.Checked)
                    dineroAPagar = precioRefresco;
                lIntroducirDinero.Visible = true;
                tbDinero.Visible = true;
            }
            else
            {
                MessageBox.Show("Elige un producto", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load(object sender, EventArgs e)
        {
            lPrecioAgua.Text = "67 €";
            precioAgua = 67;

            lPrecioCafe.Text = "86 €";
            precioCafe = 86;

            lPrecioRefresco.Text = "149 €";
            precioRefresco = 67;
        }

    }
}
