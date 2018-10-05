using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParOImpar15
{
    public partial class ParImpar : Form
    {
        public ParImpar()
        {
            InitializeComponent();
        }

        int contador = 0;
        int cantidadPar = 0;
        int cantidadImpar = 0;

        private void anadir(object sender, EventArgs e)
        {
            if (tbNum.Text.Equals(""))
                MessageBox.Show("Necesitas introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                contador++;
                int num = Int32.Parse(tbNum.Text);
                tbNum.Clear();
                if (num % 2 == 0)
                {
                    lParOImpar.Text = "PAR";
                    cantidadPar++;
                }
                else
                {
                    lParOImpar.Text = "IMPAR";
                    cantidadImpar++;
                }
                if (contador == 15)
                {
                    lCont.Text = "Fin";
                    tbNum.Enabled = false;
                    bAnadir.Enabled = false;
                    lNumPares.Text = cantidadPar.ToString();
                    lNumImpares.Text = cantidadImpar.ToString();
                }
                else
                    lCont.Text = "Quedan " + (15 - contador);
            }
        }

        private void reset(object sender, EventArgs e)
        {
            contador = 0;
            cantidadImpar = 0;
            cantidadPar = 0;
            lCont.Text = "Quedan " + 15;
            lNumPares.Text = "";
            lNumImpares.Text = "";
            bAnadir.Enabled = true;
            tbNum.Enabled = true;
            lParOImpar.Text = "";

        }
    }
}
