using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticaExamen
{
    public partial class PracticaExamen : Form
    {
        int numOperacion;
        int suma;

        public PracticaExamen()
        {
            InitializeComponent();
            numOperacion = 0;
            suma = 0;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tbOp1.Enabled = true;
            tbOp2.Enabled = true;
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            if (tbOp1.Text.Equals("") || tbOp2.Text.Equals(""))
            {
                MessageBox.Show("Introduce un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int num1 = Int32.Parse(tbOp1.Text);
                int num2 = Int32.Parse(tbOp2.Text);
                suma += num1 * num2;
                numOperacion++;
                lSumaTotal.Text = suma + "";
                lNumOperaciones.Text = numOperacion  + "";
                lbNumeros.Items.Add(num1 + " * " + num2 + "= " + (num1*num2));
                tbOp1.Enabled = false;
                tbOp2.Enabled = false;
                tbOp1.Clear();
                tbOp2.Clear();
            }
        }
    }
}
