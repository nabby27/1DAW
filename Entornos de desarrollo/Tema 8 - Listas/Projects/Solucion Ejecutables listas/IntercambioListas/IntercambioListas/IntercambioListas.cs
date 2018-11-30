using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntercambioListas
{
    public partial class IntercambioListas : Form
    {
        public IntercambioListas()
        {
            InitializeComponent();
            addItems();
        }

        private void btToRightOne_Click(object sender, EventArgs e)
        {
            if (null != lbLeft.SelectedItem)
            {
                lbRight.Items.Add(lbLeft.SelectedItem);
                lbLeft.Items.Remove(lbLeft.SelectedItem);
            }
        }

        private void btToRightAll_Click(object sender, EventArgs e)
        {
            foreach (String item in lbLeft.Items) 
            {
                lbRight.Items.Add(item);   
            }
            lbLeft.Items.Clear();
        }

        private void btToLeftAll_Click(object sender, EventArgs e)
        {
            foreach (String item in lbRight.Items)
            {
                lbLeft.Items.Add(item);
            }
            lbRight.Items.Clear();
        }

        private void btToLeftOne_Click(object sender, EventArgs e)
        {
            if (null != lbRight.SelectedItem)
            {
                lbLeft.Items.Add(lbRight.SelectedItem);
                lbRight.Items.Remove(lbRight.SelectedItem);
            }
        }

        private void addItems()
        {
            lbLeft.Items.Add("Oscar");
            lbLeft.Items.Add("es");
            lbLeft.Items.Add("el");
            lbLeft.Items.Add("mejor");
            lbLeft.Items.Add("jaja");
            lbLeft.Items.Add("risis");
            lbLeft.Items.Add("puto");
            lbLeft.Items.Add("amo");
            lbLeft.Items.Add("adios");
            lbLeft.Items.Add("jeje");
        }
    }
}
