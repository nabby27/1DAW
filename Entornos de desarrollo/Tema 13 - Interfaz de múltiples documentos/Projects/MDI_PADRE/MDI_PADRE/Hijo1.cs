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
    public partial class Hijo1 : Form
    {
        Padre padre;

        public Hijo1(Padre padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void Hijo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.hijo1Active = false;
        }
    }
}
