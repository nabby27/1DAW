using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class AcercaDe : Form
    {
        Form1 padre;
        public AcercaDe(Form1 padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void AcercaDe_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.showAcercaDeMenuActive = true;
        }
    }
}
