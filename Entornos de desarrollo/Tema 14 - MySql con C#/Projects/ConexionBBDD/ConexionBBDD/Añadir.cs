using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionBBDD
{
    public partial class Añadir : Form
    {

        ConexionBBDD padre;
        public Añadir(ConexionBBDD padre)
        {
            padre.isShowAnadirClientes = true;
            this.padre = padre;
            InitializeComponent();
        }

        public Añadir()
        {
            padre.isShowAnadirClientes = true;
            InitializeComponent();
        }

        private void btAddCliente_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            String connectionString = "server=localhost;UserID=root;database=tienda";
            if (!tbNombre.Text.Equals("") && !tbCargoContacto.Text.Equals("") &&
                !tbCiudad.Text.Equals("") && !tbContacto.Text.Equals("") &&
                !tbPais.Text.Equals("") && !tbDireccion.Text.Equals("") &&
                !tbTelefono.Text.Equals("") && !tbIDCliente.Text.Equals(""))
            {
                try
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    String query =
                        "INSERT INTO clientes values (" +
                            "'" + tbIDCliente.Text +
                            "', '" + tbNombre.Text +
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
                    tbNombre.Clear();
                    tbCargoContacto.Clear();
                    tbIDCliente.Clear();
                    tbDireccion.Clear();
                    tbContacto.Clear();
                    tbPais.Clear();
                    tbTelefono.Clear();
                    tbCiudad.Clear();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Introduce todos los datos");
            }
        }

        private void Añadir_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.isShowAnadirClientes = false;
        }

    }
}
