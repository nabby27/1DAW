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
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.Title = "Abrir fichero";
        }

        private void btFuente_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();

            tbFont.Font = fontDialog.Font;
            //tbFont.ForeColor = fontDialog.Color;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fichero;
            fichero = openFileDialog1.FileName;
            tbFile.Text = fichero;
            pictureBox1.Image = Image.FromFile(fichero);

        }

        private void btImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

    }
}
