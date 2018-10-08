using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sumar(object sender, EventArgs e)
        {
            if (tbNum1.Text.Equals("") || tbNum2.Text.Equals(""))
                MessageBox.Show("Asegurate de introducir el número 1 y el número 2", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbResultado.Text = ((Int32.Parse(tbNum1.Text) + Int32.Parse(tbNum2.Text)).ToString());
            }
        }

        private void restar(object sender, EventArgs e)
        {
            if (tbNum1.Text.Equals("") || tbNum2.Text.Equals(""))
                MessageBox.Show("Asegurate de introducir el número 1 y el número 2", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbResultado.Text = ((Int32.Parse(tbNum1.Text) - Int32.Parse(tbNum2.Text)).ToString());
            }
        }

        private void multiplicar(object sender, EventArgs e)
        {
            if (tbNum1.Text.Equals("") || tbNum2.Text.Equals(""))
                MessageBox.Show("Asegurate de introducir el número 1 y el número 2", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbResultado.Text = ((Int32.Parse(tbNum1.Text) * Int32.Parse(tbNum2.Text)).ToString());
            }
        }

        private void dividir(object sender, EventArgs e)
        {
            if (tbNum1.Text.Equals("") || tbNum2.Text.Equals(""))
                MessageBox.Show("Asegurate de introducir el número 1 y el número 2", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tbResultado.Text = ((Int32.Parse(tbNum1.Text) / Int32.Parse(tbNum2.Text)).ToString());
            }
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reiniciar(object sender, EventArgs e)
        {
            tbNum1.Clear();
            tbNum2.Clear();
            tbResultado.Clear();
        }
    }
}
