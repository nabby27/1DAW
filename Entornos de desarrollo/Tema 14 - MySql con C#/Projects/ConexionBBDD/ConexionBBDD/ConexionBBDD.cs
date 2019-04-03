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

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar mostrarCliente = new Mostrar(this);
            mostrarCliente.MdiParent = this;
            mostrarCliente.Show();
            isShowMostrarClientes = true;
        }

        private void insertarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Añadir anadirCliente = new Añadir(this);
            anadirCliente.MdiParent = this;
            anadirCliente.Show();
            isShowAnadirClientes = true;
        }

        private void eliminarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminarCliente = new Eliminar(this);
            eliminarCliente.MdiParent = this;
            eliminarCliente.Show();
            isShowEliminarClientes = true;
        }


        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe(this);
            acercaDe.MdiParent = this;
            acercaDe.Show();
            isShowAcercaDe = true;
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            mostrarClientesToolStripMenuItem.Enabled = !isShowMostrarClientes;
            insertarClientesToolStripMenuItem.Enabled = !isShowAnadirClientes;
            eliminarClientesToolStripMenuItem.Enabled = !isShowEliminarClientes;
            acercaDeToolStripMenuItem.Enabled = !isShowAcercaDe;
                
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
            cascadaToolStripMenuItem.Checked = true;
            horizontalToolStripMenuItem.Checked = false;
            verticalToolStripMenuItem.Checked = false;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            cascadaToolStripMenuItem.Checked = false;
            horizontalToolStripMenuItem.Checked = true;
            verticalToolStripMenuItem.Checked = false;
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
            cascadaToolStripMenuItem.Checked = false;
            horizontalToolStripMenuItem.Checked = false;
            verticalToolStripMenuItem.Checked = true;
        }

    }
}
