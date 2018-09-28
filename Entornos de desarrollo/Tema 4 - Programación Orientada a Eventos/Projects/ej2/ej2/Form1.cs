using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            moveX.Text = System.Convert.ToString(e.X);
            moveY.Text = System.Convert.ToString(e.Y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            downX.Text = System.Convert.ToString(e.X);
            downY.Text = System.Convert.ToString(e.Y);
            mouseBoton.Text = e.Button.ToString();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp.Text = "Soltado";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mouseClick.Text = "Ejecutado";
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mouseDobleClick.Text = "Ejecutado";
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            mouseHover.Text = "Ejecutado";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            tecla.Text = e.KeyCode.ToString();

            if (e.Alt) 
                teclaEsp.Text = "Alt";
            else if (e.Control) 
                teclaEsp.Text = "Ctrl";
            else if (e.Shift)
                teclaEsp.Text = "Shift";

            if (tecla.Text == "F10")
            {
                MessageBox.Show("Habilitado algunos métodos");
                groupBox5.Enabled = true;
            }
            if (tecla.Text == "F11")
            {
                MessageBox.Show("Habilitado movimientos del formulario"); 
                groupBox4.Enabled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress.Text = "Soltado";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lLoad.ForeColor = Color.Red;
            lResize.Visible = true;
            posXform.Text = Location.X.ToString(); // System.Convert.ToString(Location.X)
            posYform.Text = Location.Y.ToString(); // System.Convert.ToString(Location.Y)
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lShown.ForeColor = Color.Red;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            lMouve.ForeColor = Color.Red;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lResize.ForeColor = Color.Pink;
        }

        private void bArriba_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Left, this.Top - 10);
        }

        private void bAbajo_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Left, this.Top + 10);
        }

        private void bIzquierda_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Left - 10, this.Top);
        }

        private void bDerecha_Click(object sender, EventArgs e)
        {
            this.Location = new Point(this.Left + 10, this.Top);
        }

        private void bCentro_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keyUp.Text = "Soltado";
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
