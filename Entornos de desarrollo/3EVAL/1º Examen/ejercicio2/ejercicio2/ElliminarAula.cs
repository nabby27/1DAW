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
    public partial class EliminarAula : Form
    {
        Form1 padre;
        public EliminarAula(Form1 padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null | textBox1.Text == "")
            {
                MessageBox.Show( "Introduce el id", "ERROR");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection();
                String connectionString;
                connectionString = "server=localhost;UserId=root;password='';database=centro";
                try
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    String _sql = "DELETE FROM aulas where Codigo = '" + textBox1.Text + "'";
                    MySqlCommand sentencia = new MySqlCommand(_sql, conn);
                    sentencia.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("se ha eliminado", "Bien");
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error en la conexión", "ERROR");
                }
            }
        }

        private void ElliminarAula_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.deleteAulaMenuActive = true;
        }
    }
}
