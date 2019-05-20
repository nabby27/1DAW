using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1__Ficheros
{
    public partial class Ficheros : Form
    {
        public Ficheros()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                StreamReader fichero = new StreamReader(fileDialog.FileName);
                lFileName.Text = fileDialog.FileName;
                String linea;
                while ((linea = fichero.ReadLine()) != null) {
                    tbFileReaded.Text += linea + "\r\n";
                }
                fichero.Close();
            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            StreamWriter fichero = new StreamWriter("../../../TestEj1.txt");
            
            fichero.WriteLine("Hola");
            fichero.WriteLine("Adios");
            fichero.WriteLine("JEJE");
            fichero.WriteLine(DateTime.Now);
            fichero.Close();
        }

    }
}
