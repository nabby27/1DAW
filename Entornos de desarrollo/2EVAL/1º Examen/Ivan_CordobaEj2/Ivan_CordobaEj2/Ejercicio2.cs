using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ivan_CordobaEj2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();

            lbNums1.Items.Add("uno");
            lbNums1.Items.Add("dos");
            lbNums1.Items.Add("tres");
            lbNums1.Items.Add("cuatro");
            lbNums1.Items.Add("cinco");
            lbNums1.Items.Add("seis");
        }

        private void btToRightOne_Click(object sender, EventArgs e)
        {
            if (lbNums1.SelectedItem != null) 
            {
                lbNums2.Items.Add(lbNums1.SelectedItem);
                lbNums1.Items.Remove(lbNums1.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ningun número seleccionado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btToLeftOne_Click(object sender, EventArgs e)
        {
            if (lbNums2.SelectedItem != null)
            {
                lbNums1.Items.Add(lbNums2.SelectedItem);
                lbNums2.Items.Remove(lbNums2.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ningun número seleccionado","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btToRightAll_Click(object sender, EventArgs e)
        {
            foreach (String num in lbNums1.Items) 
            {
                lbNums2.Items.Add(num);
            }
            lbNums1.Items.Clear();
        }

        private void btToLeftAll_Click(object sender, EventArgs e)
        {
            foreach (String num in lbNums2.Items)
            {
                lbNums1.Items.Add(num);
            }
            lbNums2.Items.Clear();
        }
    }
}
