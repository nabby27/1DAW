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
            DBConnect db = new DBConnect();
            MySqlDataReader data = db.select("SELECT * FROM PERSONAS");
            lbTab1.Items.Clear();
            while (data.Read())
            {
                lbTab1.Items.Add(data.GetString("NOMBRE") + "\t" + data.GetString("APELLIDOS"));
            }
            db.closeConnection();
        }

        private void btTab1Siquiente_Click(object sender, EventArgs e)
        {
            clbTab2.Items.Clear();
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
                DBConnect db = new DBConnect();
                db.insert("INSERT INTO PERSONAS (NOMBRE, APELLIDOS) VALUES (" +
                            "'" + nc.tbNameNewComensalNombre.Text +
                            "','" + nc.tbNameNewComensalApellido.Text +
                            "');");

                MessageBox.Show("Insercción correcta");
                nc.tbNameNewComensalNombre.Clear();
                nc.tbNameNewComensalApellido.Clear();
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
                DBConnect db = new DBConnect();
                db.insert("INSERT INTO MENU_PERSONA (PERSONA, PLATO_PRINCIPAL, PLATO_SECUNDARIO, BEBIDA, POSTRE) VALUES (" +
                        "'" + tbTab3Comensal.Text +
                        "', '" + cbTab3Plato1.Text +
                        "', '" + cbTab3Plato2.Text +
                        "', '" + cbTab3Bebida.Text +
                        "', '" + cbTab3Postre.Text +
                    "');");    
                MessageBox.Show("Insercción correcta");
                db.closeConnection();
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
        }

        private void btTab3Siguiente_Click(object sender, EventArgs e)
        {

            DBConnect db = new DBConnect();
            MySqlDataReader data = db.select("SELECT * FROM MENU_PERSONA");
            lbTab4.Items.Clear();
            while (data.Read())
            {
                lbTab4.Items.Add(data.GetString("PERSONA"));
                lbTab4.Items.Add(data.GetString("PLATO_PRINCIPAL"));
                lbTab4.Items.Add(data.GetString("PLATO_SECUNDARIO"));
                lbTab4.Items.Add(data.GetString("BEBIDA"));
                lbTab4.Items.Add(data.GetString("POSTRE"));
                lbTab4.Items.Add("");
            }
            db.closeConnection();
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
            DBConnect db = new DBConnect();
            MySqlDataReader data = db.select("SELECT * FROM PLATOS WHERE TIPO_PLATO = 1");
            cbTab3Plato1.Items.Clear();
            while (data.Read())
            {
                cbTab3Plato1.Items.Add(data.GetString("NOMBRE"));
            }
            db.closeConnection();
        }

        private void loadPlato2()
        {
            DBConnect db = new DBConnect();
            MySqlDataReader data =  db.select("SELECT * FROM PLATOS WHERE TIPO_PLATO = 2");
            cbTab3Plato2.Items.Clear();
            while (data.Read())
            {
                cbTab3Plato2.Items.Add(data.GetString("NOMBRE"));
            }
            db.closeConnection();
        }

        private void loadPostre()
        {
            DBConnect db = new DBConnect();
            MySqlDataReader data = db.select("SELECT * FROM POSTRES");
            cbTab3Postre.Items.Clear();
            while (data.Read())
            {
                cbTab3Postre.Items.Add(data.GetString("NOMBRE"));
            }
            db.closeConnection();
        }

        private void loadBebida()
        {
            DBConnect db = new DBConnect();
            MySqlDataReader data = db.select("SELECT * FROM BEBIDAS");
            cbTab3Bebida.Items.Clear();
            while (data.Read())
            {
                cbTab3Bebida.Items.Add(data.GetString("NOMBRE"));
            }
            db.closeConnection();
        }

        private void eliminarMenuPersona()
        {
            DBConnect db = new DBConnect();
            db.delete("DELETE FROM MENU_PERSONA;");
            db.closeConnection();
        }

    }

}
