using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sumatorio
{
    public partial class Sumatorio : Form
    {
        public Sumatorio()
        {
            InitializeComponent();
        }

        private void btSum_Click(object sender, EventArgs e)
        {

        }

        private void tbNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (tbNum.Text == null || tbNum.Text == "")
                {
                    MessageBox.Show("Introduce un número", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                }
            }
        }
    }
}
