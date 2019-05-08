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
    public partial class Hijo1 : Form
    {
        private Form1 padre;
        public Hijo1(Form1 padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void Hijo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.padre.hijo1Enabled = true;
        }
    }
}
