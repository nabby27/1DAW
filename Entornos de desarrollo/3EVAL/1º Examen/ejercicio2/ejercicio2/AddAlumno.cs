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
    public partial class AddAlumno : Form
    {
        Form1 padre;

        public AddAlumno(Form1 padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void AddAlumno_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.addAlumnoMenuActive = true;
        }
    }
}
