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
    public partial class Contar : Form
    {
        public Contar()
        {
            InitializeComponent();
        }

        private void contar(object sender, EventArgs e)
        {
            if(tbNum.Text.Equals(""))
                MessageBox.Show("Necesita introducir un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                tbCont.Clear();
                lDe0.Text = "";
                int num = Int32.Parse(tbNum.Text);
                lDe0.Text = "De 0 hasta " + num.ToString();
                lDe0.Visible = true;
                if (num > 7)
                    tbCont.ScrollBars = ScrollBars.Vertical;
                for (int x = 0; x <= num; x++ )
                {
                    tbCont.AppendText(x.ToString() + "\n");
                }
            }
        }

        private void reset(object sender, EventArgs e)
        {
            tbNum.Clear();
            tbCont.Clear();
            lDe0.Visible = false;
        }

    }
}
