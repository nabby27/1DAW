using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace H_EditorDeTexto
{
    public partial class H_Editor : Form
    {
        String texto = "";
        String textoSeleccionado = "";
        Font fontPr;

        public H_Editor()
        {
            InitializeComponent();
            timer.Start();
            fontPr = textBox.Font;
            msMenuOpcionesTamano3.Checked = true;
            msMenuOpcionesFuente3.Checked = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            fecha.Text = DateTime.Now.ToString();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            cortar();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            pegar();
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void textChanged(object sender, EventArgs e)
        {
            texto = textBox.Text;
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue.Equals('x') && msMenuEdicionCortar.Enabled)
            {
                cortar();
            }

            if (e.Control && e.KeyValue.Equals('c') && msMenuEdicionCopiar.Enabled)
            {
                copiar();
            }

            if (e.Control && e.KeyValue.Equals('v') && msMenuEdicionPegar.Enabled)
            {
                pegar();
            }
        }

        private void cortar()
        {
            if (!textBox.SelectedText.Equals(""))
            {
                textoSeleccionado = textBox.SelectedText;
                textBox.Text = "";
                msMenuEdicionCortar.Enabled = false;
                msMenuEdicionCopiar.Enabled = false;
            }
        }

        private void copiar()
        {
            if (!textBox.SelectedText.Equals(""))
            {
                textoSeleccionado = textBox.SelectedText;
                msMenuEdicionCortar.Enabled = false;
                msMenuEdicionCopiar.Enabled = false;
            }
        }

        private void pegar()
        {
            textBox.Text += textoSeleccionado;
            msMenuEdicionCortar.Enabled = false;
            msMenuEdicionCopiar.Enabled = false;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fuente_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "Courier New") 
            {
                msMenuOpcionesFuente1.Checked = true;
                msMenuOpcionesFuente2.Checked = false;
                msMenuOpcionesFuente3.Checked = false;
                textBox.Font = new Font("Courier New", textBox.Font.Size);
            }

            if (sender.ToString() == "Arial")
            {
                msMenuOpcionesFuente1.Checked = false;
                msMenuOpcionesFuente2.Checked = true;
                msMenuOpcionesFuente3.Checked = false;
                textBox.Font = new Font("Arial", textBox.Font.Size);
            }

            if (sender.ToString() == "Predeterminada")
            {
                msMenuOpcionesFuente1.Checked = false;
                msMenuOpcionesFuente2.Checked = false;
                msMenuOpcionesFuente3.Checked = true;
                textBox.Font = new Font(fontPr.FontFamily, textBox.Font.Size);
            }

        }

        private void tamano_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "16")
            {
                msMenuOpcionesTamano1.Checked = true;
                msMenuOpcionesTamano2.Checked = false;
                msMenuOpcionesTamano3.Checked = false;
                textBox.Font = new Font(textBox.Font.FontFamily, 16);
            }

            if (sender.ToString() == "24")
            {
                msMenuOpcionesTamano1.Checked = false;
                msMenuOpcionesTamano2.Checked = true;
                msMenuOpcionesTamano3.Checked = false;
                textBox.Font = new Font(textBox.Font.FontFamily, 24);
            }

            if (sender.ToString() == "Predeterminado")
            {
                msMenuOpcionesTamano1.Checked = false;
                msMenuOpcionesTamano2.Checked = false;
                msMenuOpcionesTamano3.Checked = true;
                textBox.Font = new Font(textBox.Font.FontFamily, fontPr.Size);
            }
        }

        private void mouseUp(object sender, MouseEventArgs e)
        {
            if (!textBox.SelectedText.Equals("")) 
            {
                msMenuEdicionCopiar.Enabled = true;
                msMenuEdicionCortar.Enabled = true;
                msMenuEdicionPegar.Enabled = true;
            }
        }

    }

}
