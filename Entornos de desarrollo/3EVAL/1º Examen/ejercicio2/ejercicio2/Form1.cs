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
    public partial class Form1 : Form
    {
        public Boolean addAlumnoMenuActive = true;
        public Boolean addProfesorMenuActive = true;
        public Boolean showAsignaturasMenuActive = true;
        public Boolean showAcercaDeMenuActive = true;
        public Boolean deleteAulaMenuActive = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void setUp()
        {
            this.addAlumnoMenuActive = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAlumno addAlumno = new AddAlumno(this);
            addAlumno.MdiParent = this;
            addAlumno.Show();
            this.addAlumnoMenuActive = false;
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            alumnosToolStripMenuItem.Enabled = this.addAlumnoMenuActive;
            profesoresToolStripMenuItem.Enabled = this.addProfesorMenuActive;
            asignaturaasToolStripMenuItem.Enabled = this.showAsignaturasMenuActive;
            acercaDeToolStripMenuItem.Enabled = this.showAcercaDeMenuActive;
            aulaToolStripMenuItem.Enabled= this.deleteAulaMenuActive;
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProfesores addProfesores = new AddProfesores(this);
            addProfesores.MdiParent = this;
            addProfesores.Show();
            this.addProfesorMenuActive = false;
        }

        private void asignaturaasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAsignaturas showAsignaturas = new ShowAsignaturas(this);
            showAsignaturas.MdiParent = this;
            showAsignaturas.Show();
            this.showAsignaturasMenuActive = false;
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mosaicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe(this);
            acerca.MdiParent = this;
            acerca.Show();
            this.showAcercaDeMenuActive = false;
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarAula eliminar = new EliminarAula(this);
            eliminar.MdiParent = this;
            eliminar.Show();
            this.deleteAulaMenuActive = false;
        }
    }
}
