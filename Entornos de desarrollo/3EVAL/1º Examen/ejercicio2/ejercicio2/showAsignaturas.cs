using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ejercicio2
{
    public partial class ShowAsignaturas : Form
    {
        Form1 padre;
        public ShowAsignaturas(Form1 padre)
        {
            InitializeComponent();
            mostrarAsignaturas();
            this.padre = padre;
        }

        private void mostrarAsignaturas()
        {
            MySqlConnection conn = new MySqlConnection();
            String connectionString;
            connectionString = "server=localhost;User Id=root;password='';database=centro";
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                String _sql = "Select * from asignaturas";
                MySqlCommand sentencia = new MySqlCommand(_sql, conn);
                MySqlDataReader datos = sentencia.ExecuteReader();

                while (datos.Read())
                {
                    listBox1.Items.Add(datos[0].ToString() + "\t" + datos[1].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error..." + error);
            }
            conn.Close();
        }

        private void showAsignaturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.showAsignaturasMenuActive = true;
        }
    }
}
