using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TablasDeMultiplicar
{
    public partial class TabaDeMultiplicar : Form
    {
        public TabaDeMultiplicar()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            if (tbTabla.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbCalculo.Clear();
                int num = Int32.Parse(tbTabla.Text);
                lTabla.Text = ("TABLA DEL " + num);
                lTabla.Visible = true;
                for (int x = 0; x <= 10; x++) {
                    tbCalculo.AppendText("\n");
                    tbCalculo.AppendText(num + " x " + x + " = " + (num * x));
                }
            }
        }

        private void reset(object sender, EventArgs e)
        {
            lTabla.Text = "";
            tbCalculo.Clear();
            tbTabla.Clear();
        }
    }
}
