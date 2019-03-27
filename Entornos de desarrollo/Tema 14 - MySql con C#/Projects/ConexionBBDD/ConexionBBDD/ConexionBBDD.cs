using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConexionBBDD
{
    public partial class ConexionBBDD : Form
    {

        public ConexionBBDD()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mostrar mostrarCliente = new Mostrar(this);
            mostrarCliente.MdiParent = this.MdiParent;
            mostrarCliente.Show();
        }
    }
}
