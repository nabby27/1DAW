using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ej3
{
    public partial class ParesImpares : Form
    {
        public ParesImpares()
        {
            InitializeComponent();
        }

        int pares = 0;
        int impares = 0;
        int cont = 0;

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (tbNum.Text.Equals("")) 
            {
                MessageBox.Show("Introduce un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else 
            {
                cont++;
                int num1 = Int32.Parse(tbNum.Text);
                if (num1 % 2 == 0)
                {
                    pares += num1;
                    lSumaPares.Text = pares.ToString();
                    lParImpar.Text = "par";
                }
                else
                {
                    impares += num1;
                    lSumaImpares.Text = impares.ToString();
                    lParImpar.Text = "impar";
                }
                lCont.Text = cont.ToString();
            }
            if (cont == 10)
            {
                btCalculate.Enabled = false;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            btCalculate.Enabled = true;
            lParImpar.Text = "¿?";
            lSumaPares.Text = "..."; 
            lSumaImpares.Text = "...";
            lCont.Text = "...";
            tbNum.Clear();
            cont = 0;
        }

    }
}
