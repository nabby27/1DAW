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
    public partial class Mostrar : Form
    {
        ConexionBBDD padre;
        public Mostrar(ConexionBBDD padre)
        {
            padre.isShowMostrarClientes = true;
            this.padre = padre;
            InitializeComponent();
            cargarClientes();
        }

        public Mostrar()
        {
            padre.isShowMostrarClientes = true;
            InitializeComponent();
        }

        private void cargarClientes() {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='tienda'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query = "Select * from clientes";
                MySqlCommand resolveQuery = new MySqlCommand(query, connection);
                MySqlDataReader reader = resolveQuery.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader.GetString("IdCliente") + "\t" + reader.GetString("Telefono") + "\t" + reader.GetString("Nombre"));
                }
                connection.Close();
            } catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
        }

        private void Mostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            padre.isShowMostrarClientes = false;
        }
    }
}
