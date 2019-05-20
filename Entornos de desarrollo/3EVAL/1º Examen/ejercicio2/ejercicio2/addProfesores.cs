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
    public partial class AddProfesores : Form
    {
        Form1 padre;
        public AddProfesores(Form1 padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null | textBox1.Text == "" ||
                textBox2.Text == null | textBox2.Text == "" ||
                textBox3.Text == null | textBox3.Text == "" ||
                textBox4.Text == null | textBox4.Text == "" ||
                textBox5.Text == null | textBox5.Text == "")
            {
                MessageBox.Show("RELLENA TODOS LOS DATOS", "ERROR");
            }
            else
            {
                MySqlConnection conn = new MySqlConnection();
                String connectionString;
                connectionString = "server=localhost;User Id=root;password='';database=centro";
                try
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    String _sql = "insert into profesores values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +
                    textBox4.Text + "','" + textBox5.Text + "')";
                    MySqlCommand sentencia = new MySqlCommand(_sql, conn);
                    sentencia.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error..." + error);
                }
                conn.Close();
            }
        }

        private void addProfesores_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.addProfesorMenuActive = true;
        }
    }
}
