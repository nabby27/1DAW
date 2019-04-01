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
    public partial class Eliminar : Form
    {
        ConexionBBDD padre;
        public Eliminar(ConexionBBDD padre)
        {
            padre.isShowEliminarClientes = true;
            this.padre = padre;
            InitializeComponent();
        }

        public Eliminar()
        {
            padre.isShowEliminarClientes = true;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    tbIDToDelete.Clear();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
