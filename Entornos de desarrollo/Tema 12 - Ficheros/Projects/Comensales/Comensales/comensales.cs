using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Comensales
{
    public partial class Comensales : Form
    {
        public Comensales()
        {
            InitializeComponent();
            loadPlato1();
            loadPlato2();
            loadPostre();
            loadBebida();
        }

        private void btTab1Seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if (fichero.ShowDialog() == DialogResult.OK) 
            {
                String linea;
                StreamReader nombre = new StreamReader(fichero.FileName);
                while((linea = nombre.ReadLine()) != null) 
                {
                    lbTab1.Items.Add(linea);
                }
            }
        }

        private void btTab1Siquiente_Click(object sender, EventArgs e)
        {
            foreach(String item in lbTab1.Items) 
            {
                clbTab2.Items.Add(item);
            }
            tabControl.SelectTab(1);
        }

        private void btTab2NuevoComensal_Click(object sender, EventArgs e)
        {
            NuevoComensal nc = new NuevoComensal();
            if ((nc.ShowDialog() == DialogResult.OK) && !nc.tbNameNewComensal.Text.Equals(""))
            {
                clbTab2.Items.Add(nc.tbNameNewComensal.Text);
            }
        }

        private void btTab2Siguiente_Click(object sender, EventArgs e)
        {
            foreach(string item in clbTab2.CheckedItems) 
            {
                lbTab3.Items.Add(item);
            }
            tabControl.SelectTab(2);
        }

        private void lbTab3_DoubleClick(object sender, EventArgs e)
        {
            if (lbTab3.SelectedItem != null) 
            {
                tbTab3Comensal.Text = lbTab3.SelectedItem.ToString();
                lbTab3.Items.Remove(lbTab3.SelectedItem);
            }
        }

        private void btTab3Asignar_Click(object sender, EventArgs e)
        {
            lbTab3.Enabled = false;
            tbTab3Comensal.Enabled = false;
            btTab3Asignar.Enabled = false;
            cbTab3Plato1.Enabled = true;
            cbTab3Plato2.Enabled = true;
            cbTab3Postre.Enabled = true;
            cbTab3Bebida.Enabled = true;
            btTab3AsignarMenu.Enabled = true;
        }

        private void btTab3AsignarMenu_Click(object sender, EventArgs e)
        {
            if (cbTab3Plato1.Text.Equals("") || cbTab3Plato2.Text.Equals("") || cbTab3Postre.Text.Equals("") || cbTab3Bebida.Text.Equals("")) 
            {
                MessageBox.Show("Falta rellenar datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else {
                if (lbTab3.Items.Count < 1)
                {
                    btTab3Siguiente.Enabled = true;
                }
                StreamWriter stw = new StreamWriter("../../../ListaComensales.txt");
                stw.WriteLine(  "<Comensal>\n" + 
                                "\t<Nombre>" + tbTab3Comensal.Text + "</Nombre>\n" +
                                "\t<Plato1>" + cbTab3Plato1.Text + "</Plato1>\n" +
                                "\t<Plato2>" + cbTab3Plato2.Text + "</Plato2>\n" +
                                "\t<Postre>" + cbTab3Postre.Text + "</Postre>\n" + 
                                "\t<Bebida>" + cbTab3Bebida.Text + "</Bebida>\n" +
                            "</Comensal>");
                stw.Close();
                lbTab3.Enabled = true;
                tbTab3Comensal.Enabled = true;
                btTab3Asignar.Enabled = true;
                cbTab3Plato1.Enabled = false;
                cbTab3Plato2.Enabled = false;
                cbTab3Postre.Enabled = false;
                cbTab3Bebida.Enabled = false;
                btTab3AsignarMenu.Enabled = false;
            }
            tbTab3Comensal.Clear();
            cbTab3Plato1.Text = "";
            cbTab3Plato2.Text = "";
            cbTab3Postre.Text = "";
            cbTab3Bebida.Text = "";
        }

        private void loadPlato1()
        {
            String linea;
            StreamReader nombre = new StreamReader("../../../plato1.txt");
            while ((linea = nombre.ReadLine()) != null)
            {
                cbTab3Plato1.Items.Add(linea);
            }
            nombre.Close();
        }

        private void loadPlato2()
        {
            String linea;
            StreamReader nombre = new StreamReader("../../../plato2.txt");
            while ((linea = nombre.ReadLine()) != null)
            {
                cbTab3Plato2.Items.Add(linea);
            }
            nombre.Close();
        }

        private void loadPostre()
        {
            String linea;
            StreamReader nombre = new StreamReader("../../../postre.txt");
            while ((linea = nombre.ReadLine()) != null)
            {
                cbTab3Postre.Items.Add(linea);
            }
            nombre.Close();
        }

        private void loadBebida()
        {
            String linea;
            StreamReader nombre = new StreamReader("../../../bebidas.txt");
            while ((linea = nombre.ReadLine()) != null)
            {
                cbTab3Bebida.Items.Add(linea);
            }
            nombre.Close();
        }

    }
}
