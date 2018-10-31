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
                btPagar.Enabled = false;
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

        private void insertMoney(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbDinero.Text.Equals(""))
                    MessageBox.Show("Introduce dinero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!tbDinero.Text.Equals("10") && !tbDinero.Text.Equals("50") && !tbDinero.Text.Equals("100"))
                        MessageBox.Show("Solo accepta monedas de 10, 50 o 100", "INFO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        lCantidadDinero.Visible = true;
                        lCantidadNumero.Visible = true;
                        dineroIntroducido += Int32.Parse(tbDinero.Text);
                        lCantidadNumero.Text = dineroIntroducido.ToString();
                        tbDinero.Clear();
                        if (dineroIntroducido >= dineroAPagar)
                            done();
                    }
                }
            }
        }

        private void done() {
            tbDinero.Enabled = false;
            lDineroDevolver.Visible = true;
            tbDineroDevolver.Visible = true;
            tbDineroDevolver.Text = (dineroIntroducido - dineroAPagar).ToString();
            dineroIntroducido = 0;
            dineroAPagar = 0;
        }

        private void reset(object sender, EventArgs e)
        {
            tbDinero.Enabled = false;
            tbDineroDevolver.Visible = false;
            lCantidadDinero.Visible = false;
            lIntroducirDinero.Visible = false;
            lDineroDevolver.Visible = false;
            lCantidadNumero.Visible = false;
            tbDinero.Visible = false;
            tbDinero.Enabled = true;
            rbAgua.Enabled = true;
            rbCafe.Enabled = true;
            rbRefresco.Enabled = true;
            rbAgua.Checked = false;
            rbCafe.Checked = false;
            rbRefresco.Checked = false;
            btPagar.Enabled = true;
            dineroIntroducido = 0;
            dineroAPagar = 0;
        }

        private void load(object sender, EventArgs e)
        {
            lPrecioAgua.Text = "67 €";
            precioAgua = 67;

            lPrecioCafe.Text = "86 €";
            precioCafe = 86;

            lPrecioRefresco.Text = "149 €";
            precioRefresco = 149;

            tbDinero.Visible = false;
            tbDineroDevolver.Visible = false;
            lDineroDevolver.Visible = false;
            lIntroducirDinero.Visible = false;
            lCantidadDinero.Visible = false;
        }

    }
}
