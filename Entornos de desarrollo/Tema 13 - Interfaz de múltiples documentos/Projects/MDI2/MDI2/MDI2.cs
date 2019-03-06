using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using H_EditorDeTexto;
using H_Listas;
using H_Peliculas;

namespace MDI2
{
    public partial class MDI2_PADRE : Form
    {
        public bool listasActive;
        public bool editorActive;
        public bool peliculasActive;

        public MDI2_PADRE()
        {
            InitializeComponent();
            listasActive = false;
            editorActive = false;
            peliculasActive = false;
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editorActive)
            {
                H_Editor editor = new H_Editor();
                editor.MdiParent = this;
                editor.Show();
                editorActive = true;
            }
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!listasActive)
            {
                H_EjercicioListas2 listas = new H_EjercicioListas2();
                listas.MdiParent = this;
                listas.Show();
                listasActive = true;
            }
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!peliculasActive)
            {
                H_EjercicioPeliculas peliculas = new H_EjercicioPeliculas();
                peliculas.MdiParent = this;
                peliculas.Show();
                peliculasActive = true;
            }
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            editorDeTextoToolStripMenuItem.Enabled = !editorActive;
            listasToolStripMenuItem.Enabled = !listasActive;
            peliculasToolStripMenuItem.Enabled = !peliculasActive;
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
