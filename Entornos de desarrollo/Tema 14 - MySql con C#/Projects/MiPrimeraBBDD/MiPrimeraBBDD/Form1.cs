using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MiPrimeraBBDD
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection();
        String connectionString = "server=localhost;UserID=root;database=tienda";

        public Form1()
        {
            InitializeComponent();
        }

        private void btShowClientes_Click(object sender, EventArgs e)
        {
            verClientes();
        }

        private void btAddCliente_Click(object sender, EventArgs e)
        {
            if (!tbNombre.Text.Equals("") && !tbCargoContacto.Text.Equals("") &&
                !tbCiudad.Text.Equals("") && !tbContacto.Text.Equals("") &&
                !tbPais.Text.Equals("") && !tbDireccion.Text.Equals("") &&
                !tbTelefono.Text.Equals("") && !tbIdCliente.Text.Equals(""))
            {
                try
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    String query =
                        "INSERT INTO clientes values (" +
                            "'" + tbIdCliente.Text +
                            "', '" + tbNombre.Text+
                            "', '" + tbContacto.Text +
                            "', '" + tbCargoContacto.Text +
                            "', '" + tbDireccion.Text +
                            "', '" + tbCiudad.Text +
                            "', '" + tbPais.Text +
                            "', '" + tbTelefono.Text +
                        "');";
                    MySqlCommand q = new MySqlCommand(query, conn);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Insercción correcta");
                    conn.Close();
                    verClientes();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void verClientes()
        {
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                String query = "SELECT * FROM clientes";
                MySqlCommand q = new MySqlCommand(query, conn);
                MySqlDataReader reader = q.ExecuteReader();
                limpiar();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString("IdCliente") + "\t" + reader.GetString("Nombre"));
                }
                conn.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error");
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (!tbIDToDelete.Text.Equals(""))
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection();
                    String connectionString = "server=localhost;UserID=root;database=tienda";
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    String query =
                        "DELETE FROM clientes WHERE IdCliente = " + tbIDToDelete.Text + ";";
                    MySqlCommand q = new MySqlCommand(query, conn);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Eliminación correcta");
                    conn.Close();
                    verClientes();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void limpiar()
        {
            tbIDToDelete.Clear();
            listBox1.Items.Clear();
            tbNombre.Clear();
            tbCargoContacto.Clear();
            tbIdCliente.Clear();
            tbDireccion.Clear();
            tbContacto.Clear();
            tbPais.Clear();
            tbTelefono.Clear();
            tbCiudad.Clear();
        }

    }
}
