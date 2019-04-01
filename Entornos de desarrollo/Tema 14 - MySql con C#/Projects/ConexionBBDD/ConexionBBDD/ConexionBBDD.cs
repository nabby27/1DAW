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
        public Boolean isShowMostrarClientes = false;
        public Boolean isShowAnadirClientes = false;
        public Boolean isShowEliminarClientes = false;
        public Boolean isShowAcercaDe = false;

        public ConexionBBDD()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Mostrar mostrarCliente = new Mostrar(this);
            mostrarCliente.MdiParent = this;
            mostrarCliente.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Añadir anadirCliente = new Añadir(this);
            anadirCliente.MdiParent = this;
            anadirCliente.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminarCliente = new Eliminar(this);
            eliminarCliente.MdiParent = this;
            eliminarCliente.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe(this);
            acercaDe.MdiParent = this;
            acercaDe.Show();
        }

    }
}
