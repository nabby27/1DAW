using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjercicioPropio
{
    public partial class CambioDeListas : Form
    {
        public CambioDeListas()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAdd1.Enabled = false;
            btAdd2.Enabled = false;
        }

        private void btAdd1_Click(object sender, EventArgs e)
        {
            if (tbNum1.Text == null || tbNum1.Text.Equals(""))
            {
                MessageBox.Show("Introduce un número para añadir al listbox", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbNums1.Items.Add(tbNum1.Text);
                tbNum1.Clear();
                btAdd1.Enabled = false;
            }
        }

        private void btAdd2_Click(object sender, EventArgs e)
        {
            if (tbNum2.Text == null || tbNum2.Text.Equals(""))
            {
                MessageBox.Show("Introduce un número para añadir al textbox", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbNums2.Items.Add(tbNum2.Text);
                tbNum2.Clear();
                btAdd2.Enabled = false;
            }
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            List<int> nums1 = new List<int>();
            List<int> nums2 = new List<int>();
            
            foreach(var num in lbNums1.Items) 
            {
                nums1.Add(Int32.Parse(num.ToString()));
            }
            foreach (var num in lbNums2.Items)
            {
                nums2.Add(Int32.Parse(num.ToString()));
            }

            lbNums1.Items.Clear();
            lbNums2.Items.Clear();
            
            foreach (int num in nums1)
            {
                lbNums2.Items.Add(num);
            }
            foreach (int num in nums2)
            {
                lbNums1.Items.Add(num);
            }
        }

        private void tbNum1_TextChanged(object sender, EventArgs e)
        {
            if (tbNum1.Text != null && !tbNum1.Text.Equals("")) 
            {
                btAdd1.Enabled = true;
            }
        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {
            if (tbNum2.Text != null && !tbNum2.Text.Equals(""))
            {
                btAdd2.Enabled = true;
            }
        }
    }
}
