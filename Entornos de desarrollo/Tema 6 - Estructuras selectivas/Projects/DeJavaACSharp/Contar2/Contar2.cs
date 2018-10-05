using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contar2
{
    public partial class Contar2 : Form
    {
        public Contar2()
        {
            InitializeComponent();
        }

        private void contar(object sender, EventArgs e)
        {
            if (tbHasta.Text.Equals("") || tbDesde.Text.Equals(""))
                MessageBox.Show("Necesitas los dos parametros", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbCont.Clear();
                int numDesde = Int32.Parse(tbDesde.Text);
                int numHasta = Int32.Parse(tbHasta.Text);
                lDesde.Text = "Desde " + numDesde;
                lHasta.Text = "Hasta " + numHasta;
                if (numDesde + numHasta > 16)
                    tbCont.ScrollBars = ScrollBars.Vertical;
                for (int i = numDesde; i <= numHasta; i++ )
                {
                    tbCont.AppendText(i.ToString() + "\n");
                }
            }
        }

        private void reset(object sender, EventArgs e)
        {
            tbCont.Clear();
            tbDesde.Clear();
            tbHasta.Clear();
            lDesde.Text = "Desde";
            lHasta.Text = "Hasta";
        }
    }
}
