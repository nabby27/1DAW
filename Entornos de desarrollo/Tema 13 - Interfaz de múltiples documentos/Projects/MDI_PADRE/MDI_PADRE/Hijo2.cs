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
    public partial class Hijo2 : Form
    {
        Padre padre;

        public Hijo2(Padre padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void Hijo2_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.hijo2Active = false;
        }
    }
}
