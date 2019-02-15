using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comensales
{
    public partial class comensales : Form
    {
        public comensales()
        {
            InitializeComponent();
        }

        private void btTab1Seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if (fichero.ShowDialog() == DialogResult.OK) 
            {
                String linea;
                StreamReader nombre = new StreamReader(fichero.FileName);
                while((linea = nombre.ReadLine()) != null) 
                {
                    lbTab1.Items.Add(linea);
                }
            }
        }

        private void btTab1Siquiente_Click(object sender, EventArgs e)
        {
            foreach(String item in lbTab1.Items) 
            {
                clbTab2.Items.Add(item);
            }
        }

        private void btTab2Siguiente_Click(object sender, EventArgs e)
        {
            foreach(string item in clbTab2.CheckedItems) 
            {
                lbTab3.Items.Add(item);
            }
        }

        private void lbTab3_DoubleClick(object sender, EventArgs e)
        {
            if (lbTab3.SelectedItem != null) 
            {
                tbTab3Comensal.Text = lbTab3.SelectedItem.ToString();
            }
        }

        private void btTab3Asiganr_Click(object sender, EventArgs e)
        {
            tbTab3Comensal.Enabled = false;
            btTab3Asiganr.Enabled = false;
        }

    }
}
