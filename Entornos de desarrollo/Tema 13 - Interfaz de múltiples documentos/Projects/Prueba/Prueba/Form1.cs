using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        Hijo1 hijo1;
        Hijo2 hijo2;

        public Boolean hijo1Enabled = true;
        public Boolean hijo2Enabled = true;

        public Form1()
        {
            InitializeComponent();
            this.hijo1 = new Hijo1(this);
            this.hijo2 = new Hijo2(this);
            this.hijo1.MdiParent = this;
            this.hijo2.MdiParent = this;
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            hijo1ToolStripMenuItem1.Enabled = hijo1Enabled;
            hijo2ToolStripMenuItem1.Enabled = hijo2Enabled;
        }

        private void hijo1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hijo1Enabled = false;
            this.hijo1.Show();
        }

        private void hijo2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hijo2Enabled = false;
            this.hijo2.Show();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
