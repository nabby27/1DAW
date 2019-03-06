using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_PADRE
{
    public partial class Padre : Form
    {
        public bool hijo1Active;
        public bool hijo2Active;

        public Padre()
        {
            InitializeComponent();
            hijo1Active = false;
            hijo2Active = false;
        }

        private void hijo1_Click(object sender, EventArgs e)
        {
            if (!hijo1Active) {
                Hijo1 hijo1 = new Hijo1(this);
                hijo1.MdiParent = this;
                hijo1.Show();
                hijo1Active = true;
            }
        }

        private void hijo2_Click(object sender, EventArgs e)
        {
            if (!hijo2Active)
            {
                Hijo2 hijo2 = new Hijo2(this);
                hijo2.MdiParent = this;
                hijo2.Show();
                hijo2Active = true;
            }
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            MenuHijo1.Enabled = !hijo1Active;
            MenuHijo2.Enabled = !hijo2Active;
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void organizarIconosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
