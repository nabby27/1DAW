using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CuadroDialogo
{
    public partial class cuadroDialogo : Form
    {
        public cuadroDialogo()
        {
            InitializeComponent();
        }

        private void btFuente_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
        }
    }
}
