using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Primo
{
    public partial class Primo : Form
    {
        public Primo()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            if (tbNum.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
            {
                int num = Int32.Parse(tbNum.Text);
                Boolean primo = true;

                for (int x = 2; x < num; x++)
                {
                    if (num % x == 0) 
                    {
                        primo = false;
                    }
                }

                lPrimo.Visible = true;
                if (primo)
                    lPrimo.Text = "ES PRIMO";
                else
                    lPrimo.Text = "NO ES PRIMO";

            }
        }

        private void reset(object sender, EventArgs e)
        {
            lPrimo.Visible = false;
            lPrimo.Text = "";
            tbNum.Clear();
        }
    }
}
