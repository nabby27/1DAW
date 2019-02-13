using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ivan_CordobaEj1
{
    public partial class Ejercicio1 : Form
    {
        int precioCerezas;
        int precioFresas;
        int precioNaranjas;
        int precioMelocotonoes;
        int precioPeras;

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            if (tbPriceCerezas.Text.Equals("") || tbPriceFresas.Text.Equals("") || tbPriceNaranjas.Text.Equals("") || tbPriceMelocontones.Text.Equals("") || tbPricePeras.Text.Equals(""))
            {
                MessageBox.Show("Necesitas introducir el precio de todas las frutas", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                precioCerezas = Int32.Parse(tbPriceCerezas.Text);
                precioFresas = Int32.Parse(tbPriceFresas.Text);
                precioNaranjas = Int32.Parse(tbPriceNaranjas.Text);
                precioMelocotonoes = Int32.Parse(tbPriceMelocontones.Text);
                precioPeras = Int32.Parse(tbPricePeras.Text);
                tbPriceCerezas.Enabled = false;
                tbPriceFresas.Enabled = false;
                tbPriceNaranjas.Enabled = false;
                tbPriceMelocontones.Enabled = false;
                tbPricePeras.Enabled = false;
                btSetPrice.Enabled = false;

                tbCant.Enabled = true;
                btCereza.Enabled = true;
                btFresa.Enabled = true;
                btNaranja.Enabled = true;
                btMelocoton.Enabled = true;
                btPera.Enabled = true;
            }
        }

        private void btClean_Click_1(object sender, EventArgs e)
        {
            lbTicket.Items.Clear();
        }

        private void btCereza_Click(object sender, EventArgs e)
        {
            if (tbCant.Text.Equals(""))
            {
                MessageBox.Show("Necesitas introducir la cantidad en kg", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String fruta = "CEREZAS";
                int precio = precioCerezas;
                int total = precio * Int32.Parse(tbCant.Text);
                String registro = fruta + "\t" + tbCant.Text + "Kg.\t" + precio + "\t" + total + "€";
                lbTicket.Items.Add(registro);
                lTotal.Text = (Int32.Parse(lTotal.Text) + total).ToString();
            }
        }

        private void btFresa_Click(object sender, EventArgs e)
        {
            if (tbCant.Text.Equals(""))
            {
                MessageBox.Show("Necesitas introducir la cantidad en kg", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String fruta = "FRESA";
                int precio = precioFresas;
                int total = precio * Int32.Parse(tbCant.Text);
                String registro = fruta + "\t\t" + tbCant.Text + "Kg.\t" + precio + "\t" + total + "€";
                lbTicket.Items.Add(registro);
                lTotal.Text = (Int32.Parse(lTotal.Text) + total).ToString();
            }
        }

        private void btNaranja_Click(object sender, EventArgs e)
        {
            if (tbCant.Text.Equals(""))
            {
                MessageBox.Show("Necesitas introducir la cantidad en kg", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String fruta = "MANDARINAS";
                int precio = precioNaranjas;
                int total = precio * Int32.Parse(tbCant.Text);
                String registro = fruta + "\t" + tbCant.Text + "Kg.\t" + precio + "\t" + total + "€";
                lbTicket.Items.Add(registro);
                lTotal.Text = (Int32.Parse(lTotal.Text) + total).ToString();
            }
        }

        private void btMelocoton_Click(object sender, EventArgs e)
        {
            if (tbCant.Text.Equals(""))
            {
                MessageBox.Show("Necesitas introducir la cantidad en kg", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String fruta = "MELOCOTONES";
                int precio = precioMelocotonoes;
                int total = precio * Int32.Parse(tbCant.Text);
                String registro = fruta + "\t" + tbCant.Text + "Kg.\t" + precio + "\t" + total + "€";
                lbTicket.Items.Add(registro);
                lTotal.Text = (Int32.Parse(lTotal.Text) + total).ToString();
            }
        }

        private void btPera_Click(object sender, EventArgs e)
        {
            if (tbCant.Text.Equals(""))
            {
                MessageBox.Show("Necesitas introducir la cantidad en kg", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String fruta = "PERAS";
                int precio = precioPeras;
                int total = precio * Int32.Parse(tbCant.Text);
                String registro = fruta + "\t\t" + tbCant.Text + "Kg.\t" + precio + "\t" + total + "€";
                lbTicket.Items.Add(registro);
                lTotal.Text = (Int32.Parse(lTotal.Text) + total).ToString();
            }
        }

    }
}
