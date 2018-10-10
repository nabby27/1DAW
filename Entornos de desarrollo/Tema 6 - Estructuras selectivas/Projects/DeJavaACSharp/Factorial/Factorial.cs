using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            if (tbCalcular.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int num = Int32.Parse(tbCalcular.Text);
                int resultado = 1;

                if (num == -1)
                    this.Close();
                else if (num == 0)
                    tbResultado.Text = "0";
                else
                {
                    for (int x = 1; x <= num; x++)
                    {
                        resultado *= x;
                    }
                    tbResultado.Text = resultado.ToString();
                }
            }
        }

        private void reset(object sender, EventArgs e)
        {
            tbResultado.Clear();
            tbCalcular.Clear();
        }
    }
}
