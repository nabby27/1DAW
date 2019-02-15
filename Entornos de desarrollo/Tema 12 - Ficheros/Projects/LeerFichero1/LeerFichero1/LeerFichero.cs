using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeerFichero1
{
    public partial class LeerFichero : Form
    {
        public LeerFichero()
        {
            InitializeComponent();
        }

        private void btToTextbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if (fichero.ShowDialog() == DialogResult.OK) 
            {
                String linea;
                StreamReader nombre = new StreamReader(fichero.FileName);
                lrutaFichero.Text = fichero.FileName.ToString();
                while((linea = nombre.ReadLine()) != null) 
                {
                    textBox1.Text += linea + "\r\n";
                }
                nombre.Close();
            }
        }

        private void btToListbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                String linea;
                StreamReader nombre = new StreamReader(fichero.FileName);
                lrutaFichero.Text = fichero.FileName.ToString();
                while ((linea = nombre.ReadLine()) != null)
                {
                    listBox1.Items.Add(linea);
                }
                nombre.Close();
            }
        }

        private void btToCheckedListbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog fichero = new OpenFileDialog();
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                String linea;
                StreamReader nombre = new StreamReader(fichero.FileName);
                lrutaFichero.Text = fichero.FileName.ToString();
                while ((linea = nombre.ReadLine()) != null)
                {
                    checkedListBox1.Items.Add(linea);
                }
                nombre.Close();
            }
        }

        private void btCheckedTolistbox_Click(object sender, EventArgs e)
        {
            foreach (String item in checkedListBox1.CheckedItems) 
            {
                listBoxItemsChecked.Items.Add(item);
            }
        }

        private void btCrearFichero_Click(object sender, EventArgs e)
        {
            StreamWriter nombre = new StreamWriter("../../../Ejemplo.txt");
            nombre.WriteLine("1");
            nombre.WriteLine("2");
            nombre.WriteLine("3");
            nombre.Close();
        }
        
        private void btToRichtextbox_Click(object sender, EventArgs e)
        {
            if (File.Exists("../../../Ejemplo.txt"))
            {
                String linea;
                StreamReader nombre = new StreamReader("../../../Ejemplo.txt");
                while ((linea = nombre.ReadLine()) != null)
                {
                    richTextBox1.Text += linea + "\r\n";
                }
                nombre.Close();
            } else 
            {
                MessageBox.Show("No existe el fichero", "EEROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btToCombobox_Click(object sender, EventArgs e)
        {
            String linea;
            StreamReader nombre = new StreamReader("../../../Ejemplo.txt");
            while ((linea = nombre.ReadLine()) != null)
            {
                comboBox1.Items.Add(linea);
            }
            nombre.Close();
        }

    }

}
