using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atras
{
    public partial class Atras : Form
    {
        public Atras()
        {
            InitializeComponent();
        }

        private void contar(object sender, EventArgs e)
        {
            if (tbNum.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbCont.Clear();
                int num = Int32.Parse(tbNum.Text);
                if (num > 10)
                    tbCont.ScrollBars = ScrollBars.Vertical;
                for (int x = num; x >= 0; x--)
                {
                    tbCont.AppendText(x.ToString() + "\n");
                }
            }
        }

        private void reset(object sender, EventArgs e)
        {
            tbNum.Clear();
            tbCont.Clear();
        }

    }
}
