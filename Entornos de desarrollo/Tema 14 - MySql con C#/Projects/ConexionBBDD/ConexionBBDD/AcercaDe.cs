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
    public partial class AcercaDe : Form
    {
        ConexionBBDD padre;
        public AcercaDe(ConexionBBDD padre)
        {
            padre.isShowAcercaDe = true;
            this.padre = padre;
            InitializeComponent();
        }

        public AcercaDe()
        {
            padre.isShowAcercaDe = true;
            InitializeComponent();
        }

        private void AcercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.isShowAcercaDe = false;
        }
    }
}
