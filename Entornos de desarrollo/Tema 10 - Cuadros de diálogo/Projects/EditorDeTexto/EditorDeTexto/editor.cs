using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditorDeTexto
{
    public partial class editor : Form
    {
        String texto = "";

        public editor()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            texto = textBox.SelectedText;
            textBox.Text = "";
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            texto = textBox.SelectedText;
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            textBox.Text += texto;
        }

    }
}
