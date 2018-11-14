using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumerosNaturales
{
    public partial class NumerosNaturales : Form
    {
        public NumerosNaturales()
        {
            InitializeComponent();
        }

        int contador = 0;

        private void contar(object sender, EventArgs e)
        {
            tbResultadoCalcular.Text = "";
            if (tbInitNumCalcular.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número de inicio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tbFinNumCalcular.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número de fin", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Int32.Parse(tbFinNumCalcular.Text) < Int32.Parse(tbInitNumCalcular.Text))
                MessageBox.Show("El número inicial no puede ser mayor al final", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int numInicial = Int32.Parse(tbInitNumCalcular.Text);
                int numFinal = Int32.Parse(tbFinNumCalcular.Text);

                for (int i = numInicial; i <= numFinal; i++)
                {
                    tbResultadoCalcular.AppendText(i + "\n");
                }
            }
        }

        private void resetContar(object sender, EventArgs e)
        {
            tbInitNumCalcular.Text = "";
            tbFinNumCalcular.Text = "";
            tbResultadoCalcular.Text = "";
        }

        private void calcularTabla(object sender, EventArgs e)
        {
            tbResultadoTabla.Text = "";
            if (tbNumTabla.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int num = Int32.Parse(tbNumTabla.Text);

                for (int i = 0; i <= 10; i++)
                {
                    tbResultadoTabla.AppendText(num + " * " + i + " = " + (num * i) + "\n");
                }
            }
        }

        private void resetTabla(object sender, EventArgs e)
        {
            tbResultadoTabla.Text = "";
            tbNumTabla.Text = "";
        }

        private void calcularParImpar(object sender, EventArgs e)
        {
            foreach (int item in lbResultadoParImpar.Items)
            {
                if (item % 2 == 0)
                    tbPar.AppendText(item + "\n");
                else
                    tbImpar.AppendText(item + "\n");
            }
        }

        private void resetParImpar(object sender, EventArgs e)
        {
            tbImpar.Text = "";
            tbPar.Text = "";
            lbResultadoParImpar.Text = "";
            tbNumParImpar.Text = "";
            tbNumParImpar.Enabled = true;
            lbResultadoParImpar.Items.Clear();
        }

        private void addParImpar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (tbNumParImpar.Text.Equals(""))
                    MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    lbResultadoParImpar.Items.Add((Int32.Parse(tbNumParImpar.Text)));
                    
                    if (contador > 13)
                    {
                        tbNumParImpar.Enabled = false;
                    }
                    
                    tbNumParImpar.Text = "";
                    contador++;
                }
            }
           
        }

    }
}
