using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset();
            cargarOptativa1();
            cargarOptativa2();
        }

        private void reset()
        {
            clbAlumnos.Items.Clear();
            btSiguiente1.Enabled = false;
            btSiguiente2.Enabled = false;
            btSeleccionar.Enabled = true;
            btAsignarAlumno.Enabled = false;
            cbOptativas1.Enabled = false;
            cbOptativas2.Enabled = false;
            btFinalizar.Enabled = false;
            lbInfo.Items.Clear();
        }

        private void btSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    clbAlumnos.Items.Add(line);
                }
                btSiguiente1.Enabled = true;
                btSeleccionar.Enabled = false;
            }
        }

        private void btSiguiente1_Click(object sender, EventArgs e)
        {
            foreach (Object name in clbAlumnos.CheckedItems) {
                lbAlumnosAsignar.Items.Add(name);
            }
            tabControl.SelectTab(1);
        }

        private void cargarOptativa1()
        {
            StreamReader sr = new StreamReader("optativa1.txt");
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                cbOptativas1.Items.Add(line);
            }
            sr.Close();
        }

        private void cargarOptativa2()
        {
            StreamReader sr = new StreamReader("optativa2.txt");
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                cbOptativas2.Items.Add(line);
            }
            sr.Close();
        }

        private void lbAlumnosAsignar_DoubleClick(object sender, EventArgs e)
        {
            if (lbAlumnosAsignar.SelectedItem != null)
            {
                tbAsignar.Text = lbAlumnosAsignar.SelectedItem.ToString();
                lbAlumnosAsignar.Items.Remove(lbAlumnosAsignar.SelectedItem);
                btAsignarAlumno.Enabled = true;
                cbOptativas1.Enabled = true;
                cbOptativas2.Enabled = true;
            }
        }

        private void btAsignarAlumno_Click(object sender, EventArgs e)
        {
            tbAsignar.Enabled = false;
            lbAlumnosAsignar.Enabled = false;
        }

        private void btAsignarOptativa_Click(object sender, EventArgs e)
        {
            String optativa1 = cbOptativas1.Text;
            string optativa2 = cbOptativas2.Text;
            if (optativa1 == "" | optativa1 == null | optativa2 == "" | optativa2 == null)
            {
                MessageBox.Show("Error", "Introduce optativas");
            }
            else
            {
                if (lbAlumnosAsignar.Items.Count < 1)
                {
                    btSiguiente2.Enabled = true;
                }
                
                StreamWriter sw = new StreamWriter("../../../Optativas_Alumnos.txt", true);
                sw.WriteLine("<alumno>");
                sw.WriteLine("\t <nombre>");
                sw.WriteLine("\t\t" + tbAsignar.Text);
                sw.WriteLine("\t </nombre>");
                sw.WriteLine("\t <optativa1>");
                sw.WriteLine("\t\t" + cbOptativas1.Text);
                sw.WriteLine("\t </optativa1>");
                sw.WriteLine("\t <optativa2>");
                sw.WriteLine("\t\t" + cbOptativas2.Text);
                sw.WriteLine("\t </optativa2>");
                sw.WriteLine("</alumno>");
                sw.WriteLine("");
                sw.Close();

                tbAsignar.Enabled = true;
                lbAlumnosAsignar.Enabled = true;
                tbAsignar.Clear();
                cbOptativas1.Text = "";
                cbOptativas2.Text = "";
                cbOptativas1.Enabled = false;
                cbOptativas2.Enabled = false;
            }

        }

        private void btSiguiente2_Click(object sender, EventArgs e)
        {
            btFinalizar.Enabled = true;
            tabControl.SelectTab(2);
            StreamReader sr = new StreamReader("../../../Optativas_Alumnos.txt");
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                lbInfo.Items.Add(line);
            }
            sr.Close();
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            reset();
            File.Delete("../../../Optativas_Alumnos.txt");
            tabControl.SelectTab(0);
        }

    }
}
