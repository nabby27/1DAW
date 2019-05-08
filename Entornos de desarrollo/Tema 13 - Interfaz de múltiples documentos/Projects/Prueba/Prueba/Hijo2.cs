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
    public partial class Hijo2 : Form
    {
        private Form1 padre;

        public Hijo2(Form1 padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void Hijo2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.padre.hijo2Enabled = true;
        }
    }
}
