using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjercicioListas2
{
    public partial class EjercicioListas2 : Form
    {
        public EjercicioListas2()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (rbListBox.Checked)
            {
                if (checkNumber())
                {
                    lb.Items.Add(tbNum.Text);
                    tbListBox.Text = lb.Items.Count.ToString();
                }
            }
            else if (rbComboBox.Checked)
            {
                if (checkNumber())
                {
                    cmb.Items.Add(tbNum.Text);
                    tbComboBox.Text = cmb.Items.Count.ToString();
                }
            }
            else if (rbCheckedListBox.Checked)
            {
                if (checkNumber())
                {
                    clb.Items.Add(tbNum.Text);
                    tbCheckListBox.Text = clb.Items.Count.ToString();
                }
            }
            tbNum.Clear();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (checkNumber())
            {
                if (rbListBox.Checked)
                {
                    if (checkNumber())
                    {
                        lb.Items.Remove(tbNum.Text);
                        tbListBox.Text = lb.Items.Count.ToString();
                    }
                }
                else if (rbComboBox.Checked)
                {
                    if (checkNumber())
                    {
                        cmb.Items.Remove(tbNum.Text);
                        tbComboBox.Text = cmb.Items.Count.ToString();
                    }
                }
                else if (rbCheckedListBox.Checked)
                {
                    if (checkNumber())
                    {
                        clb.Items.Remove(tbNum.Text);
                        tbCheckListBox.Text = clb.Items.Count.ToString();
                    }
                }
                tbNum.Clear();
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            
            if (rbListBox.Checked)
            { 
                lSeleccionUnica.Text = lb.SelectedItem.ToString();                
            }
            else if (rbComboBox.Checked) 
            {
                lSeleccionUnica.Text = cmb.SelectedItem.ToString();
            }
            else if (rbCheckedListBox.Checked)
            {
                foreach (String item in clb.CheckedItems) 
                {
                    lbMultiseleccion.Items.Add(item);
                    lSeleccionUnica.Text = "";
                }
            }
        }

        private Boolean checkNumber()
        {
            if (tbNum.Text.Equals(""))
            {
                MessageBox.Show("Introduce algo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
