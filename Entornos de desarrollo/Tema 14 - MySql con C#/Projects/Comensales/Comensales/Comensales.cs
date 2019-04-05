using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Comensales
{
    public partial class Comensales : Form
    {

        public Comensales()
        {
            InitializeComponent();
            eliminarMenuPersona();
            loadPlato1();
            loadPlato2();
            loadPostre();
            loadBebida();
        }

        private void btTab1Seleccionar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='COMENSALES'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query = "SELECT * FROM PERSONAS";
                MySqlCommand resolveQuery = new MySqlCommand(query, connection);
                MySqlDataReader reader = resolveQuery.ExecuteReader();
                lbTab1.Items.Clear();
                while (reader.Read())
                {
                    lbTab1.Items.Add(reader.GetString("NOMBRE") + "\t" + reader.GetString("APELLIDOS"));
                }
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
        }

        private void btTab1Siquiente_Click(object sender, EventArgs e)
        {
            foreach(String item in lbTab1.Items) 
            {
                clbTab2.Items.Add(item);
            }
            tabControl.SelectTab(1);
        }

        private void btTab2NuevoComensal_Click(object sender, EventArgs e)
        {
            NuevoComensal nc = new NuevoComensal();
            if ((nc.ShowDialog() == DialogResult.OK) && !nc.tbNameNewComensalNombre.Text.Equals("") && !nc.tbNameNewComensalApellido.Text.Equals(""))
            {
                MySqlConnection conn = new MySqlConnection();
                String connectionString = "server=localhost;UserID=root;database=COMENSALES";
                try
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    String query =
                        "INSERT INTO PERSONAS (NOMBRE, APELLIDOS) VALUES (" +
                            "'" + nc.tbNameNewComensalNombre.Text +
                            "','" + nc.tbNameNewComensalApellido.Text + 
                            "');";
                    MySqlCommand q = new MySqlCommand(query, conn);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Insercción correcta");
                    conn.Close();
                    nc.tbNameNewComensalNombre.Clear();
                    nc.tbNameNewComensalApellido.Clear();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btTab2Siguiente_Click(object sender, EventArgs e)
        {
            lbTab3.Items.Clear();
            foreach(string item in clbTab2.CheckedItems) 
            {
                lbTab3.Items.Add(item);
            }
            tabControl.SelectTab(2);
        }

        private void lbTab3_DoubleClick(object sender, EventArgs e)
        {
            if (lbTab3.SelectedItem != null) 
            {
                tbTab3Comensal.Text = lbTab3.SelectedItem.ToString();
                lbTab3.Items.Remove(lbTab3.SelectedItem);
            }
        }

        private void btTab3Asignar_Click(object sender, EventArgs e)
        {
            if (!tbTab3Comensal.Text.Equals(""))
            {
                lbTab3.Enabled = false;
                tbTab3Comensal.Enabled = false;
                btTab3Asignar.Enabled = false;
                cbTab3Plato1.Enabled = true;
                cbTab3Plato2.Enabled = true;
                cbTab3Postre.Enabled = true;
                cbTab3Bebida.Enabled = true;
                btTab3AsignarMenu.Enabled = true;
            }
        }

        private void btTab3AsignarMenu_Click(object sender, EventArgs e)
        {
            if (cbTab3Plato1.Text.Equals("") || cbTab3Plato2.Text.Equals("") || cbTab3Postre.Text.Equals("") || cbTab3Bebida.Text.Equals("")) 
            {
                MessageBox.Show("Falta rellenar datos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else {
                if (lbTab3.Items.Count < 1)
                {
                    btTab3Siguiente.Enabled = true;
                }
                MySqlConnection conn = new MySqlConnection();
                String connectionString = "server=localhost;UserID=root;database=COMENSALES";
                try
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    String query =
                        "INSERT INTO MENU_PERSONA (PERSONA, PLATO_PRINCIPAL, PLATO_SECUNDARIO, BEBIDA, POSTRE) VALUES (" +
                            "'" + tbTab3Comensal.Text +
                            "', '" + cbTab3Plato1.Text +
                            "', '" + cbTab3Plato2.Text +
                            "', '" + cbTab3Bebida.Text +
                            "', '" + cbTab3Postre.Text +
                        "');";
                    MySqlCommand q = new MySqlCommand(query, conn);
                    q.ExecuteNonQuery();
                    MessageBox.Show("Insercción correcta");
                    conn.Close();
                    lbTab3.Enabled = true;
                    tbTab3Comensal.Enabled = true;
                    btTab3Asignar.Enabled = true;
                    cbTab3Plato1.Enabled = false;
                    cbTab3Plato2.Enabled = false;
                    cbTab3Postre.Enabled = false;
                    cbTab3Bebida.Enabled = false;
                    btTab3AsignarMenu.Enabled = false;
                    tbTab3Comensal.Clear();
                    cbTab3Plato1.Text = "";
                    cbTab3Plato2.Text = "";
                    cbTab3Postre.Text = "";
                    cbTab3Bebida.Text = "";
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btTab3Siguiente_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='COMENSALES'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query = "SELECT * FROM MENU_PERSONA";
                MySqlCommand resolveQuery = new MySqlCommand(query, connection);
                MySqlDataReader reader = resolveQuery.ExecuteReader();
                lbTab4.Items.Clear();
                while (reader.Read())
                {
                    lbTab4.Items.Add(reader.GetString("PERSONA"));
                    lbTab4.Items.Add(reader.GetString("PLATO_PRINCIPAL"));
                    lbTab4.Items.Add(reader.GetString("PLATO_SECUNDARIO"));
                    lbTab4.Items.Add(reader.GetString("BEBIDA"));
                    lbTab4.Items.Add(reader.GetString("POSTRE"));
                    lbTab4.Items.Add("");
                }
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
            tabControl.SelectTab(3);
            btTab4Finalizar.Enabled = true;
        }

        private void btTab4Finalizar_Click(object sender, EventArgs e)
        {
            lbTab1.Items.Clear();
            clbTab2.Items.Clear();
            lbTab3.Items.Clear();
            lbTab4.Items.Clear();
            btTab4Finalizar.Enabled = false;
            tabControl.SelectTab(0);
        }

        private void loadPlato1()
        {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='COMENSALES'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query = "SELECT * FROM PLATOS WHERE TIPO_PLATO = 1";
                MySqlCommand resolveQuery = new MySqlCommand(query, connection);
                MySqlDataReader reader = resolveQuery.ExecuteReader();
                cbTab3Plato1.Items.Clear();
                while (reader.Read())
                {
                    cbTab3Plato1.Items.Add(reader.GetString("NOMBRE"));
                }
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
        }

        private void loadPlato2()
        {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='COMENSALES'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query = "SELECT * FROM PLATOS WHERE TIPO_PLATO = 2";
                MySqlCommand resolveQuery = new MySqlCommand(query, connection);
                MySqlDataReader reader = resolveQuery.ExecuteReader();
                cbTab3Plato2.Items.Clear();
                while (reader.Read())
                {
                    cbTab3Plato2.Items.Add(reader.GetString("NOMBRE"));
                }
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
        }

        private void loadPostre()
        {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='COMENSALES'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query = "SELECT * FROM POSTRES";
                MySqlCommand resolveQuery = new MySqlCommand(query, connection);
                MySqlDataReader reader = resolveQuery.ExecuteReader();
                cbTab3Postre.Items.Clear();
                while (reader.Read())
                {
                    cbTab3Postre.Items.Add(reader.GetString("NOMBRE"));
                }
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
        }

        private void loadBebida()
        {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='COMENSALES'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query = "SELECT * FROM BEBIDAS";
                MySqlCommand resolveQuery = new MySqlCommand(query, connection);
                MySqlDataReader reader = resolveQuery.ExecuteReader();
                cbTab3Bebida.Items.Clear();
                while (reader.Read())
                {
                    cbTab3Bebida.Items.Add(reader.GetString("NOMBRE"));
                }
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
        }

        private void eliminarMenuPersona()
        {
            MySqlConnection connection = new MySqlConnection();
            String connectionString = "Server='localhost';User Id='root';Password='';Database='COMENSALES'";
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                String query =
                        "DELETE FROM MENU_PERSONA;";
                MySqlCommand q = new MySqlCommand(query, connection);
                q.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error en la conexión", "ERROR");
            }
        }
    }
}
