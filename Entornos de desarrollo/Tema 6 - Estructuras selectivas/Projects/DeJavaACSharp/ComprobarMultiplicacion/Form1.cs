using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComprobarMultiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int fallos = 0;

        private void start(object sender, EventArgs e)
        {
            if (tbTabla.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbResult.Visible = true;
                btCheck.Visible = true;
                lPor.Visible = true;
                lIgual.Visible = true;
                lNum.Visible = true;
                lX.Visible = true;

                tbTabla.Enabled = false;
                btStart.Enabled = false;

                int num = Int32.Parse(tbTabla.Text);
                lX.Text = "0";
                lNum.Text = num.ToString();
            }
        }

        private void check(object sender, EventArgs e)
        {
            if (tbTabla.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int result = Int32.Parse(tbResult.Text);
                int num = Int32.Parse(lNum.Text);
                int x = Int32.Parse(lX.Text);

                lTextResult.Visible = true;
                if (num * x == result)
                {
                    lTextResult.ForeColor = Color.Green;
                    lTextResult.Text = "Correcto!";
                }
                else
                {
                    lTextResult.ForeColor = Color.Red;
                    lTextResult.Text = "Has fallado! el resultado de " + num + " * " + x + " es: " + (num * x);
                    fallos++;
                }


                if (x == 10)
                {
                    btCheck.Enabled = false;
                    tbResult.Enabled = false;
                    showFinish();
                } else
                    lX.Text = (++x).ToString();
            }

        }

        private void reset(object sender, EventArgs e)
        {
            tbTabla.Enabled = true;
            btStart.Enabled = true;
            tbResult.Enabled = true;
            tbResult.Visible = false;
            lTextResult.Visible = false;
            btCheck.Visible = false;
            lPor.Visible = false;
            lIgual.Visible = false;
            lNum.Visible = false;
            lX.Visible = false;
            fallos = 0;
        }

        private void showFinish() 
        {
            lTextResult.ForeColor = Color.Orange;
            lTextResult.Text = "Has tenido " + fallos + "fallo/s";
        }

    }
}
